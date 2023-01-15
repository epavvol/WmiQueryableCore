using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;

namespace VNetDev.WmiQueryableCore.DCom.Extensions
{
    internal static class ManagementObjectTypeConverter
    {
        internal static object ToWmiType(object value)
        {
            switch (value)
            {
                case DateTime dateTime:
                    return ManagementDateTimeConverter.ToDmtfDateTime(dateTime);
                default:
                    return value;
            }
        }

        internal static object FromWmiType(Type type, object value)
        {
            if (value == null)
            {
                return null;
            }

            if (type == typeof(DateTime))
            {
                return ManagementDateTimeConverter.ToDateTime(value.ToString());
            }

            if (type.IsGenericType && value is ICollection<object> enumerableValue)
            {
                var genericType = type.GenericTypeArguments.First();
                var genericCollectionType = typeof(List<>).MakeGenericType(genericType);
                var result = Activator.CreateInstance(genericCollectionType);
                var addMethod = genericCollectionType.GetMethods()
                    .First(x => x.Name == "Add");
                foreach (var entry in enumerableValue
                    .Select(listEntry =>
                        FromWmiType(genericType, listEntry)))
                {
                    addMethod.Invoke(result, new[] {entry});
                }

                return result;
            }

            return Convert.ChangeType(value, type);
        }
    }
}