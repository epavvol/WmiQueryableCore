using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace VNetDev.WmiQueryableCore
{
    /// <summary>
    /// WMI Object Tracker
    /// </summary>
    public class ObjectTracker
    {
        private readonly Dictionary<object, Dictionary<string, object>> _trackedObjects = new Dictionary<object, Dictionary<string, object>>();

        /// <summary>
        /// Add tracked object
        /// </summary>
        /// <param name="obj">Object</param>
        public void TrackObject(object obj)
        {
            if (_trackedObjects.ContainsKey(obj))
            {
                return;
            }

            _trackedObjects.Add(
                obj,
                null);

            ResetTrackedObject(obj);
        }


        /// <summary>
        /// Remove tracked object
        /// </summary>
        /// <param name="obj">Object</param>
        public void RemoveTrackedObject(object obj)
        {
            if (_trackedObjects.ContainsKey(obj))
            {
                _trackedObjects.Remove(obj);
            }
        }

        /// <summary>
        /// Reset tracked object
        /// </summary>
        /// <param name="obj">Object</param>
        public void ResetTrackedObject(object obj)
        {
            if (_trackedObjects.ContainsKey(obj))
            {
                _trackedObjects[obj] = obj
                    .GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .ToDictionary(
                        x => x.Name,
                        x => x.GetValue(obj));
            }
        }

        /// <summary>
        /// Checks if property was changed
        /// </summary>
        /// <param name="obj">Object</param>
        /// <param name="propertyName">Property name</param>
        /// <returns></returns>
        public bool CheckPropertyChanged(object obj, string propertyName)
        {
            if (!_trackedObjects.ContainsKey(obj))
            {
                return false;
            }

            var property = obj.GetType().GetProperty(propertyName);
            if (property is null)
            {
                return false;
            }

            return property.GetValue(obj)?.ToString() != _trackedObjects[obj][propertyName]?.ToString();
        }
    }
}