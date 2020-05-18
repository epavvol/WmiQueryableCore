using System;
using System.Management;

namespace VNetDev.WmiQueryableCore.DCom.Extensions
{
    internal static class ManagementObjectExtension
    {
        internal static void SetWmiValue(this ManagementBaseObject wmiObject, string key, object value) =>
            wmiObject[key] = ManagementObjectTypeConverter.ToWmiType(value);

        internal static T GetWmiValue<T>(this ManagementBaseObject wmiObject, string key) =>
            (T) GetWmiValue(wmiObject, typeof(T), key);

        internal static object GetWmiValue(this ManagementBaseObject wmiObject, Type type, string key) =>
            ManagementObjectTypeConverter.FromWmiType(type, wmiObject[key]);
    }
}