using System;
using System.Linq;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Types
{
    internal class WqlSelectDelegate: IWqlObject
    {
        public Delegate Delegate { get; private set; }
        public IWqlObject SetValue(params object[] values)
        {
            var o = values.FirstOrDefault();
            if (o != null && o is Delegate selectDelegate)
                Delegate = selectDelegate;
            return this;
        }
    }
}