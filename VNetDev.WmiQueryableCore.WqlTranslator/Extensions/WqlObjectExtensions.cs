using System;
using System.Collections.Generic;
using System.Linq;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Extensions
{
    internal static class WqlObjectExtensions
    {
        public static string AggregateString(this IEnumerable<IWqlPredicate> predicateEnumerable) =>
            predicateEnumerable.Aggregate(new List<string>(), (s, p) =>
                {
                    s.Add(p.ToString());
                    return s;
                },
                sl => string.Join(" AND ", sl));

        public static string AggregateString(this IEnumerable<IWqlClassObject> joinEnumerable) =>
            joinEnumerable.Aggregate(new List<string>(), (s, j) =>
            {
                s.Add(j.ToString());
                return s;
            }, s => string.Join(Environment.NewLine, s));
    }
}