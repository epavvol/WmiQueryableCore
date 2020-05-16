using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;
using VNetDev.WmiQueryableCore.WqlTranslator.Extensions;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Types
{
    internal class WqlQuery : IWqlQuery
    {
        private string _name;
        private string _alias;
        private readonly ICollection<IWqlPredicate> _predicates = new List<IWqlPredicate>();
        private readonly ICollection<IWqlClassObject> _joins = new List<IWqlClassObject>();

        #region Alias Map

        private IReadOnlyDictionary<string, string> _aliasMap;

        public WqlQuery UpdateAliasMap(Dictionary<string, string> map)
        {
            _aliasMap = new ReadOnlyDictionary<string, string>(map);
            return this;
        }

        public (string, string) GetAliasMapValue(string key)
        {
            if (_aliasMap.TryGetValue(key, out var result))
            {
                return (string.Empty, result);
            }

            var keyPrefix = $"{key}.";
            try
            {
                var valuePair = _aliasMap.First(x => x.Key.StartsWith(keyPrefix));
                return (valuePair.Key.Replace(keyPrefix, string.Empty), valuePair.Value);
            }
            catch
            {
                throw new InvalidOperationException();
            }
        }

        public bool HasMap() => _aliasMap != null;
        public IReadOnlyDictionary<string, string> GetAliasMap() => _aliasMap;

        #endregion

        public Type WqlQueryResultType { get; internal set; }

        #region Select Delegates

        private readonly Stack<WqlSelectDelegate> _selectDelegates = new Stack<WqlSelectDelegate>();

        internal WqlQuery AddSelectDelegate(object selectDelegate) =>
            selectDelegate is WqlSelectDelegate wqlSelectDelegate ? AddSelectDelegate(wqlSelectDelegate) : this;

        internal WqlQuery AddSelectDelegate(WqlSelectDelegate selectDelegate)
        {
            _selectDelegates.Push(selectDelegate);
            return this;
        }

        public object ProceedDelegates(object input) =>
            _selectDelegates
                .Aggregate(
                    input,
                    (p, d) => 
                        d.Delegate.DynamicInvoke(p));

        #endregion


        public WqlQuery SetAlias(string alias)
        {
            _alias = string.IsNullOrWhiteSpace(alias) ? throw new ArgumentException(nameof(alias)) : alias;
            return this;
        }

        public WqlQuery AddJoin(IWqlClassObject join)
        {
            _joins.Add(join);
            return this;
        }

        public IWqlObject SetValue(params object[] values)
        {
            if (values.Length < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            _name = values[0].ToString();
            return this;
        }
        
        internal IWqlClassObject AddPredicate(object predicate) =>
            predicate is IWqlPredicate wqlPredicate ? AddPredicate(wqlPredicate) : this;


        public IWqlClassObject AddPredicate(IWqlPredicate predicate)
        {
            _predicates.Add(predicate);
            return this;
        }

        public string GetAlias(string followerBy = null) => (_alias ?? _name) + followerBy;

        public override string ToString()
        {
            var sb = new StringBuilder()
                .AppendLine("SELECT * ")
                .AppendLine($"FROM {_name} {(_joins.Any() ? $"{_alias} " : string.Empty)}");
            if (_joins.Any())
                sb.AppendLine(_joins.AggregateString());
            if (_predicates.Any())
                sb.Append("WHERE ")
                .AppendLine(_predicates.AggregateString());
            return sb.ToString();
        }
    }
}