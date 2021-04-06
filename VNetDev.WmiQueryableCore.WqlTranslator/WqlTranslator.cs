using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using VNetDev.WmiQueryableCore.Attributes;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;
using VNetDev.WmiQueryableCore.WqlTranslator.Helpers;
using VNetDev.WmiQueryableCore.WqlTranslator.Types;

namespace VNetDev.WmiQueryableCore.WqlTranslator
{
    internal class WqlTranslator : ExpressionVisitor
    {
        #region Private fields

        private readonly WqlQuery _query;
        private readonly Stack<IWqlObject> _objectStack;
        private Dictionary<string, Func<string, (string, string)>> _lambdaParameterLinks;

        #endregion

        #region Alias provider

        private ushort _nextAliasIndex;
        private string GetNextAlias() => $"a{_nextAliasIndex++}";

        #endregion

        #region Constructors

        internal WqlTranslator()
        {
            _objectStack = new Stack<IWqlObject>();
            _objectStack.Push(
                _query = new WqlQuery()
                    .SetAlias(
                        GetNextAlias()));
        }

        #endregion

        #region Translator

        public IWqlQuery Translate(Expression expression)
        {
            var partiallyEvaluatedExpression = Evaluator.PartialEval(expression);
            Visit(partiallyEvaluatedExpression);
            return _query;
        }

        #endregion

        #region Expression Visitor Overrides

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Method.DeclaringType == typeof(Queryable))
            {
                Visit(node.Arguments[0]);

                switch (node.Method.Name)
                {
                    case "Single":
                    case "SingleOrDefault":
                    case "First":
                    case "FirstOrDefault":
                    case "Where":
                    case "Count":
                        if (node.Arguments.Count >= 2)
                        {
                            _objectStack.Push(new WqlPredicate());
                            Visit(node.Arguments[1]);
                            _query.AddPredicate(_objectStack.Pop());
                        }

                        return node;
                    case "Join":
                        // Create new Join object
                        var join = new WqlJoin()
                            .SetAlias(GetNextAlias());
                        _query.AddJoin(join);

                        // Set Join class name
                        _objectStack.Push(join);
                        Visit(node.Arguments[1]);

                        //Create Predicate left argument
                        _objectStack.Push(WqlFactory.GetValueObject());
                        Visit(node.Arguments[2]);
                        _objectStack.Push(WqlFactory.GetValueObject());
                        Visit(node.Arguments[3]);

                        // Creating predicate and adding to query
                        join.AddPredicate(WqlFactory
                            .GetPredicate()
                            .SetOperator("=")
                            .SetRight(_objectStack.Pop()
                                .SetValue(join.GetAlias(".")))
                            .SetLeft(_objectStack.Pop()
                                .SetValue(_query.GetAlias("."))));

                        // Selector
                        Visit(node.Arguments[4]);
                        _objectStack.Pop();
                        return node;
                    case "Select":
                        _objectStack.Push(new WqlSelectDelegate());
                        Visit(node.Arguments[1]);
                        _query.AddSelectDelegate(_objectStack.Pop());
                        return node;
                    case "OrderBy":
                    case "OrderByDescending":
                        throw new NotSupportedException("Ordering is not yet supported.");
                }
            }

            if (node.Method.DeclaringType == typeof(Enumerable) && node.Method.Name == nameof(Enumerable.Any))
            {
                if (_objectStack.Peek() is IWqlPredicate anyPredicate)
                {
                    _objectStack.Push(new WqlValue());
                    Visit(node.Arguments[0]);
                    anyPredicate.SetLeft(_objectStack.Pop());

                    _objectStack.Push(new WqlValue());
                    Visit(node.Arguments[1]);
                    anyPredicate.SetRight(_objectStack.Pop());

                    anyPredicate.SetOperator("LIKE");
                }

                return node;
            }

            if (node.Method.DeclaringType == typeof(string))
            {
                switch (node.Method.Name)
                {
                    case nameof(string.ToUpper):
                    case nameof(string.ToLower):
                        // Nothing to do, as WQL is not case sensitive
                        return node;
                    case nameof(string.Equals):
                        if (!(_objectStack.Peek() is WqlPredicate eqPredicate))
                            throw new InvalidOperationException("Predicate in stack expected!");

                        _objectStack.Push(new WqlValue());
                        Visit(node.Object);
                        eqPredicate.SetLeft(_objectStack.Pop());
                        eqPredicate.SetOperator("=");
                        _objectStack.Push(new WqlValue());
                        Visit(node.Arguments[0]);
                        eqPredicate.SetRight(_objectStack.Pop());
                        return node;
                    case nameof(string.StartsWith):
                        if (_objectStack.Peek() is WqlValue startsWithValue)
                        {
                            Visit(node.Arguments[0]);
                            startsWithValue.Append = "%";
                            return node;
                        }

                        if (!(_objectStack.Peek() is WqlPredicate swPredicate))
                            throw new InvalidOperationException("Predicate in stack expected!");

                        _objectStack.Push(new WqlValue());
                        Visit(node.Object);
                        swPredicate.SetLeft(_objectStack.Pop());
                        swPredicate.SetOperator("LIKE");
                        _objectStack.Push(new WqlValue
                        {
                            Append = "%"
                        });
                        Visit(node.Arguments[0]);
                        swPredicate.SetRight(_objectStack.Pop());
                        return node;
                    case nameof(string.EndsWith):
                        if (_objectStack.Peek() is WqlValue endsWithValue)
                        {
                            Visit(node.Arguments[0]);
                            endsWithValue.Prepand = "%";
                            return node;
                        }

                        if (!(_objectStack.Peek() is WqlPredicate ewPredicate))
                            throw new InvalidOperationException("Predicate in stack expected!");

                        _objectStack.Push(new WqlValue());
                        Visit(node.Object);
                        ewPredicate.SetLeft(_objectStack.Pop());
                        ewPredicate.SetOperator("LIKE");
                        _objectStack.Push(new WqlValue
                        {
                            Prepand = "%"
                        });
                        Visit(node.Arguments[0]);
                        ewPredicate.SetRight(_objectStack.Pop());
                        return node;
                    case nameof(string.Contains):
                        if (_objectStack.Peek() is WqlValue containsValue)
                        {
                            Visit(node.Arguments[0]);
                            containsValue.Prepand = "%";
                            containsValue.Append = "%";
                            return node;
                        }

                        if (!(_objectStack.Peek() is WqlPredicate cntPredicate))
                            throw new InvalidOperationException("Predicate in stack expected!");

                        _objectStack.Push(new WqlValue());
                        Visit(node.Object);
                        cntPredicate.SetLeft(_objectStack.Pop());
                        cntPredicate.SetOperator("LIKE");
                        _objectStack.Push(new WqlValue
                        {
                            Append = "%",
                            Prepand = "%"
                        });
                        Visit(node.Arguments[0]);
                        cntPredicate.SetRight(_objectStack.Pop());
                        return node;
                }
            }

            if (typeof(IEnumerable).IsAssignableFrom(node.Method.DeclaringType))
            {
                switch (node.Method.Name)
                {
                    case "Contains":
                        if (_objectStack.Peek() is IWqlPredicate containsPredicate)
                        {
                            if (node.Object is ConstantExpression constantExpression &&
                                typeof(IEnumerable).IsAssignableFrom(constantExpression.Type))
                            {
                                _objectStack.Push(new WqlValue());
                                Visit(node.Arguments[0]);
                                containsPredicate.SetLeft(_objectStack.Pop());

                                _objectStack.Push(new WqlValue());
                                Visit(node.Object);
                                containsPredicate.SetRight(_objectStack.Pop());

                                containsPredicate.SetOperator("IN");
                            }
                            else
                            {
                                _objectStack.Push(new WqlValue());
                                Visit(node.Object);
                                containsPredicate.SetLeft(_objectStack.Pop());

                                _objectStack.Push(new WqlValue());
                                Visit(node.Arguments[0]);
                                containsPredicate.SetRight(_objectStack.Pop());

                                containsPredicate.SetOperator("=");
                            }
                        }

                        return node;
                }
            }

            throw new NotSupportedException(
                $"Method '{node.Method.Name}' for type '{node.Method.DeclaringType?.Name}'.");
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            object result = null;
            object quotes = null;
            if (node.Value is IQueryable && node.Value.GetType().IsGenericType)
            {
                var constantTypeGeneric = node.Value.GetType().GetGenericArguments()[0];
                _query.WqlQueryResultType = constantTypeGeneric;
                var classAttribute = WqlAttribute.Get<WmiClassAttribute>(constantTypeGeneric);
                result = string.IsNullOrWhiteSpace(classAttribute?.Name)
                    ? constantTypeGeneric.Name
                    : classAttribute.Name;
                /*if (_objectStack.Peek() == _query && node.Value.GetType().FullName == typeof(WmiClassSet<>).FullName)
                {
                }*/
            }
            else if (node.Value != null)
            {
                switch (Type.GetTypeCode(node.Value.GetType()))
                {
                    case TypeCode.Boolean:
                        result = (bool) node.Value ? "1" : "0";
                        break;
                    case TypeCode.String:
                        result = node.Value;
                        quotes = "'";
                        break;
                    case TypeCode.DateTime:
                        result = node.Value;
                        break;
                    case TypeCode.Char:
                    case TypeCode.Byte:
                    case TypeCode.Decimal:
                    case TypeCode.Double:
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.SByte:
                    case TypeCode.Single:
                    case TypeCode.UInt16:
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                        result = node.Value;
                        break;
                    case TypeCode.DBNull:
                    case TypeCode.Empty:
                    case TypeCode.Object:
                        if (node.Value is IEnumerable<string> stringEnumerable)
                        {
                            result = $"({string.Join(", ", stringEnumerable.Select(x => $"'{x}'"))})";
                            break;
                        }

                        throw new NotSupportedException(
                            $"Constant of type '{node.Value.GetType().Name}' is not supported!");
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            _objectStack.Peek().SetValue(result, quotes);
            return node;
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            switch (_objectStack.Peek())
            {
                case WqlSelectDelegate wqlSelectDelegate:
                    wqlSelectDelegate.SetValue(node.Compile());
                    return node;
                case WqlJoin join:
                {
                    _query.WqlQueryResultType = node.ReturnType;
                    _lambdaParameterLinks = new Dictionary<string, Func<string, (string, string)>>();

                    if (_query.HasMap())
                    {
                        _lambdaParameterLinks.Add(node.Parameters[0].ToString(), _query.GetAliasMapValue);
                    }
                    else
                    {
                        _lambdaParameterLinks.Add(node.Parameters[0].ToString(),
                            _ => (string.Empty, _query.GetAlias()));
                    }

                    _lambdaParameterLinks.Add(node.Parameters[1].ToString(), _ => (string.Empty, join.GetAlias()));

                    Visit(node.Body);
                    return node;
                }
            }

            return base.VisitLambda(node);
        }

        protected override Expression VisitNew(NewExpression node)
        {
            if (_objectStack.Peek() is WqlJoin)
            {
                var newMap = new Dictionary<string, string>();

                for (var i = 0; i < node.Members.Count; i++)
                {
                    if (node.Arguments[i] is ParameterExpression parameter)
                    {
                        var aliasPair = _lambdaParameterLinks[parameter.Name](string.Empty);
                        newMap[node.Members[i].Name] = aliasPair.Item2;
                    }
                    else if (node.Arguments[i] is MemberExpression member)
                    {
                        var aliasPair =
                            _lambdaParameterLinks[((ParameterExpression) member.Expression).Name](member.Member.Name);
                        newMap[node.Members[i].Name] = aliasPair.Item2;
                    }
                }

                _query.UpdateAliasMap(newMap);
                _lambdaParameterLinks = null;
            }

            return base.VisitNew(node);
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node.NodeType == ExpressionType.Not)
            {
                if (_objectStack.Peek() is WqlPredicate currentPredicate)
                    currentPredicate.SetNot();
                else if (_objectStack.Peek() is WqlValue currentValue)
                {
                    currentValue.SetNot();
                }
                else
                    throw new InvalidOperationException("Predicate in stack expected!");
            }

            return base.VisitUnary(node);
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Expression == null)
            {
                throw new NotSupportedException("Nullable expression members are not supported!");
            }

            if (node.Expression.NodeType == ExpressionType.Parameter)
            {
                _objectStack.Peek().SetValue(node.Member.Name);
                return node;
            }

            if (node.Expression is MemberExpression memberExpression)
            {
                var aliasPair = _query.GetAliasMapValue(memberExpression.Member.Name);
                if (!string.IsNullOrWhiteSpace(aliasPair.Item1))
                {
                    throw new InvalidOperationException();
                }

                _objectStack.Peek().SetValue(node.Member.Name).SetValue($"{aliasPair.Item2}.");
                return node;
            }

            throw new NotSupportedException($"The member '{node.Member.Name}' is not supported");
        }

        private static readonly Dictionary<ExpressionType, string> BinaryOperators =
            new Dictionary<ExpressionType, string>
            {
                {ExpressionType.OrElse, "OR"},
                {ExpressionType.AndAlso, "AND"},
                {ExpressionType.Equal, "="},
                {ExpressionType.NotEqual, "!="},
                {ExpressionType.GreaterThan, ">"},
                {ExpressionType.GreaterThanOrEqual, ">="},
                {ExpressionType.LessThan, "<"},
                {ExpressionType.LessThanOrEqual, "<="}
            };

        protected override Expression VisitBinary(BinaryExpression node)
        {
            switch (node.NodeType)
            {
                case ExpressionType.Add:
                    break;
                case ExpressionType.AddAssign:
                    break;
                case ExpressionType.AddAssignChecked:
                    break;
                case ExpressionType.AddChecked:
                    break;
                case ExpressionType.And:
                    break;
                case ExpressionType.AndAlso:
                case ExpressionType.OrElse:
                    if (!(_objectStack.Peek() is WqlPredicate currentLogicalPredicate))
                        throw new InvalidOperationException("Predicate in stack expected!");

                    IWqlObject leftLogicalValue;
                    if (node.Left is BinaryExpression)
                    {
                        _objectStack.Push(new WqlPredicate());
                        Visit(node.Left);
                        leftLogicalValue = _objectStack.Pop();
                    }
                    else
                    {
                        _objectStack.Push(new WqlValue());
                        Visit(node.Left);
                        leftLogicalValue = new WqlPredicate()
                            .SetLeft(_objectStack.Pop())
                            .SetOperator("=")
                            .SetRight(new WqlValue().SetValue(1));
                    }

                    IWqlObject rightLogicalValue;
                    if (node.Right is BinaryExpression)
                    {
                        _objectStack.Push(new WqlPredicate());
                        Visit(node.Right);
                        rightLogicalValue = _objectStack.Pop();
                    }
                    else
                    {
                        _objectStack.Push(new WqlValue());
                        Visit(node.Right);
                        rightLogicalValue = new WqlPredicate()
                            .SetLeft(_objectStack.Pop())
                            .SetOperator("=")
                            .SetRight(new WqlValue().SetValue(1));
                    }

                    currentLogicalPredicate
                        .SetLeft(leftLogicalValue)
                        .SetOperator(BinaryOperators[node.NodeType])
                        .SetRight(rightLogicalValue);

                    return node;
                case ExpressionType.Equal:
                case ExpressionType.NotEqual:
                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                    if (!(_objectStack.Peek() is WqlPredicate currentEqualityPredicate))
                        throw new InvalidOperationException("Predicate in stack expected!");

                    if (node.Left is BinaryExpression)
                        _objectStack.Push(new WqlPredicate());
                    else
                        _objectStack.Push(new WqlValue());
                    Visit(node.Left);
                    var leftEqualityValue = _objectStack.Pop();

                    if (node.Right is BinaryExpression)
                        _objectStack.Push(new WqlPredicate());
                    else
                        _objectStack.Push(new WqlValue());
                    Visit(node.Right);
                    var rightEqualityValue = _objectStack.Pop();

                    currentEqualityPredicate
                        .SetLeft(leftEqualityValue)
                        .SetOperator(BinaryOperators[node.NodeType])
                        .SetRight(rightEqualityValue);

                    return node;
                case ExpressionType.AndAssign:
                    break;
                case ExpressionType.ArrayIndex:
                    break;
                case ExpressionType.ArrayLength:
                    break;
                case ExpressionType.Assign:
                    break;
                case ExpressionType.Block:
                    break;
                case ExpressionType.Call:
                    break;
                case ExpressionType.Coalesce:
                    break;
                case ExpressionType.Conditional:
                    break;
                case ExpressionType.Constant:
                    break;
                case ExpressionType.Convert:
                    break;
                case ExpressionType.ConvertChecked:
                    break;
                case ExpressionType.DebugInfo:
                    break;
                case ExpressionType.Decrement:
                    break;
                case ExpressionType.Default:
                    break;
                case ExpressionType.Divide:
                    break;
                case ExpressionType.DivideAssign:
                    break;
                case ExpressionType.Dynamic:
                    break;
                case ExpressionType.ExclusiveOr:
                    break;
                case ExpressionType.ExclusiveOrAssign:
                    break;
                case ExpressionType.Extension:
                    break;
                case ExpressionType.Goto:
                    break;
                case ExpressionType.Increment:
                    break;
                case ExpressionType.Index:
                    break;
                case ExpressionType.Invoke:
                    break;
                case ExpressionType.IsFalse:
                    break;
                case ExpressionType.IsTrue:
                    break;
                case ExpressionType.Label:
                    break;
                case ExpressionType.Lambda:
                    break;
                case ExpressionType.LeftShift:
                    break;
                case ExpressionType.LeftShiftAssign:
                    break;
                case ExpressionType.ListInit:
                    break;
                case ExpressionType.Loop:
                    break;
                case ExpressionType.MemberAccess:
                    break;
                case ExpressionType.MemberInit:
                    break;
                case ExpressionType.Modulo:
                    break;
                case ExpressionType.ModuloAssign:
                    break;
                case ExpressionType.Multiply:
                    break;
                case ExpressionType.MultiplyAssign:
                    break;
                case ExpressionType.MultiplyAssignChecked:
                    break;
                case ExpressionType.MultiplyChecked:
                    break;
                case ExpressionType.Negate:
                    break;
                case ExpressionType.NegateChecked:
                    break;
                case ExpressionType.New:
                    break;
                case ExpressionType.NewArrayBounds:
                    break;
                case ExpressionType.NewArrayInit:
                    break;
                case ExpressionType.Not:
                    break;
                case ExpressionType.OnesComplement:
                    break;
                case ExpressionType.Or:
                    break;
                case ExpressionType.OrAssign:
                    break;
                case ExpressionType.Parameter:
                    break;
                case ExpressionType.PostDecrementAssign:
                    break;
                case ExpressionType.PostIncrementAssign:
                    break;
                case ExpressionType.Power:
                    break;
                case ExpressionType.PowerAssign:
                    break;
                case ExpressionType.PreDecrementAssign:
                    break;
                case ExpressionType.PreIncrementAssign:
                    break;
                case ExpressionType.Quote:
                    break;
                case ExpressionType.RightShift:
                    break;
                case ExpressionType.RightShiftAssign:
                    break;
                case ExpressionType.RuntimeVariables:
                    break;
                case ExpressionType.Subtract:
                    break;
                case ExpressionType.SubtractAssign:
                    break;
                case ExpressionType.SubtractAssignChecked:
                    break;
                case ExpressionType.SubtractChecked:
                    break;
                case ExpressionType.Switch:
                    break;
                case ExpressionType.Throw:
                    break;
                case ExpressionType.Try:
                    break;
                case ExpressionType.TypeAs:
                    break;
                case ExpressionType.TypeEqual:
                    break;
                case ExpressionType.TypeIs:
                    break;
                case ExpressionType.UnaryPlus:
                    break;
                case ExpressionType.Unbox:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            throw new NotSupportedException($"{node.NodeType} binary operation is not supported!");
        }

        #endregion
    }
}