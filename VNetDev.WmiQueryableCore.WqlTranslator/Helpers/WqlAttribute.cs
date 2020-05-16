using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Helpers
{
    internal static class WqlAttribute
    {
        internal static TAttribute Get<TAttribute>(object obj)
            where TAttribute : Attribute =>
            Get<TAttribute>(obj?.GetType());

        internal static TAttribute Get<TAttribute, TObject>()
            where TAttribute : Attribute
            where TObject : class =>
            Get<TAttribute>(typeof(TObject));

        internal static TAttribute Get<TAttribute>(Type objectType)
            where TAttribute : Attribute =>
            (TAttribute) Get(typeof(TAttribute), objectType);

        internal static Attribute Get(Type attributeType, Type objectType) =>
            objectType == null ? null : Attribute.GetCustomAttribute(objectType, attributeType);
    }
}