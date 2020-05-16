using System;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;
using VNetDev.WmiQueryableCore.WqlTranslator.Extensions;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Types
{
    internal class WqlValue : IWqlObject
    {
        private object _value;
        private string _bracketOrQuote;
        internal string Append { get; set; }
        internal string Prepand { get; set; }
        private bool _not;

        public WqlValue SetNot(bool not = true)
        {
            _not = not;
            return this;
        }

        public bool IsNot => _not;


        public IWqlObject SetValue(params object[] values)
        {
            switch (values.Length)
            {
                case 1:
                    if (_value == null)
                    {
                        _value = values[0];
                    }
                    else if (Prepand == null)
                    {
                        Prepand = values[0].ToString();
                    }

                    break;
                case 2:
                    _value = values[0];
                    _bracketOrQuote = values[1]?.ToString();
                    break;
                case 3:
                    _value = values[0] ??
                             throw new ArgumentException($"First argument of {nameof(values)} cannot be null!");
                    Prepand = values[1].ToString();
                    Append = values[2].ToString();
                    break;
                case 4:
                    _value = values[0] ??
                             throw new ArgumentException($"First argument of {nameof(values)} cannot be null!");
                    Prepand = values[1].ToString();
                    Append = values[2].ToString();
                    _bracketOrQuote = values[3].ToString();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(values));
            }

            if (_value is DateTime dateTimeValue)
            {
                _value = dateTimeValue.ToDmtf();
            }

            return this;
        }

        public override string ToString() => $"{_bracketOrQuote}{Prepand}{_value ?? "NULL"}{Append}{_bracketOrQuote}";
    }
}