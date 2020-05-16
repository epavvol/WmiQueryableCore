using System;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Types
{
    internal class WqlPredicate : IWqlPredicate
    {
        private IWqlObject _left;
        private IWqlObject _right;
        private string _operator;
        private bool _not;

        private bool Not
        {
            get
            {
                var result = _not;
                if (_left is WqlValue leftValue && leftValue.IsNot)
                {
                    result = !result;
                }
                if (_right is WqlValue rightValue && rightValue.IsNot)
                {
                    result = !result;
                }
                return result;
            }
        }

        public IWqlObject SetValue(params object[] values)
        {
            switch (values.Length)
            {
                case 1:
                    if (!(values[0] is IWqlObject valueObject))
                    {
                        throw new ArgumentException("IWqlObject is required!");
                    }

                    if (_left == null)
                    {
                        return SetLeft(valueObject);
                    }

                    return _right == null ? SetRight(valueObject) : this;

                case 2:
                    if (!(values[0] is IWqlObject left) || !(values[1] is IWqlObject right))
                    {
                        throw new ArgumentException("IWqlObjects are required!");
                    }

                    return SetLeft(left).SetRight(right);
                default:
                    throw new ArgumentOutOfRangeException(nameof(values));
            }
        }

        public IWqlPredicate SetNot(bool not = true)
        {
            _not = not;
            return this;
        }

        public IWqlPredicate SetLeft(IWqlObject left)
        {
            _left = left;
            return this;
        }

        public IWqlPredicate SetRight(IWqlObject right)
        {
            _right = right;
            return this;
        }

        public IWqlPredicate SetOperator(string op)
        {
            _operator = op;
            return this;
        }

        public override string ToString() => $"({(Not ? "NOT " : "")}{_left} {_operator} {_right})";
    }
}