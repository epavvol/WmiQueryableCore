using System;
using System.Management;
using System.Resources;

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
                return null;
            if (type == typeof(DateTime))
            {
                return ManagementDateTimeConverter.ToDateTime(value.ToString());
            }

            return Convert.ChangeType(value, type);
        }
    }
}