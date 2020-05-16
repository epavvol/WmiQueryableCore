using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;
using VNetDev.WmiQueryableCore.WqlTranslator.Extensions;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Types
{
    internal class WqlJoin : IWqlClassObject
    {
        private string _name;
        private string _alias;
        private readonly ICollection<IWqlPredicate> _predicates = new List<IWqlPredicate>();

        internal WqlJoin SetAlias(string alias)
        {
            _alias = string.IsNullOrWhiteSpace(alias) ? throw new ArgumentException(nameof(alias)) : alias;
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

        public IWqlClassObject AddPredicate(IWqlPredicate predicate)
        {
            _predicates.Add(predicate);
            return this;
        }

        public string GetAlias(string followedBy = null) => (_alias ?? _name) + followedBy;

        public override string ToString() => $"INNER JOIN {_name} AS {_alias} ON {_predicates.AggregateString()}";
    }
}