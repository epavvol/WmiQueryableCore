using Microsoft.Management.Infrastructure;
using System.Linq;
using System.Reflection;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Cim.Extensions
{
    internal static class CimInstanceExtensions
    {
        internal static void AssignObjectValues(this CimInstance cimInstance, object objectInstance)
        {
            var currentObjectType = objectInstance.GetType();
            foreach (var property in currentObjectType.GetProperties())
            {
                if (currentObjectType.GetProperty(property.Name)?
                        .GetCustomAttribute<WmiIgnorePropertyAttribute>(false) != null)
                {
                    continue;
                }

                var objectPropertyAttribute = currentObjectType
                    .GetProperty(property.Name)?
                    .GetCustomAttribute<WmiPropertyAttribute>(false);
                var propertyName = objectPropertyAttribute?.Name ?? property.Name;
                property.SetValue(
                    objectInstance,
                    cimInstance?.CimInstanceProperties[propertyName]?.Value);
            }
        }

        internal static string[] GetWmiObjectPropertyNames(this CimInstance cimInstance)
        {
            var result = Enumerable.Empty<string>();
            foreach (var objectProperty in cimInstance.CimInstanceProperties)
            {
                result = result.Append(objectProperty.Name.ToLower());
            }

            return result.ToArray();
        }
        
        public static void SetWmiValues(this CimInstance cimInstance, ObjectTracker objectTracker,
            object objectInstance)
        {
            var currentObjectType = objectInstance.GetType();
            var availablePropertyNames = cimInstance.GetWmiObjectPropertyNames();
            foreach (var property in currentObjectType.GetProperties())
            {
                if (!objectTracker.CheckPropertyChanged(objectInstance, property.Name))
                {
                    continue;
                }

                if (currentObjectType.GetProperty(property.Name)?
                        .GetCustomAttribute<WmiIgnorePropertyAttribute>(false) != null)
                {
                    continue;
                }

                var objectPropertyAttribute = currentObjectType
                    .GetProperty(property.Name)?
                    .GetCustomAttribute<WmiPropertyAttribute>(false);

                var propertyName = objectPropertyAttribute?.Name ?? property.Name;
                if (!availablePropertyNames.Contains(propertyName.ToLower()))
                {
                    continue;
                }

                try
                {
                    cimInstance.CimInstanceProperties[propertyName].Value = property.GetValue(objectInstance);
                }
                catch
                {
                    // ignored
                }
            }
        }
    }
}