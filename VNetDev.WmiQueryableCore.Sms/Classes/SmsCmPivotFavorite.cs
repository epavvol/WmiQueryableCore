using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CMPivotFavorite
    /// </summary>
    [WmiClass(Name = "SMS_CMPivotFavorite")]
    public class SmsCmPivotFavorite
    {
        /// <summary>
        /// WMI static method <c>UpdateCMPivotFavorite</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <param name="query">WMI Property <c>Query</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateCmPivotFavoriteDelegate(WmiContext wmiContext, string name = default, string query = default);
        /// <summary>
        /// WMI static method <c>UpdateCMPivotFavorite</c>.
        /// </summary>
        public static UpdateCmPivotFavoriteDelegate UpdateCmPivotFavorite;
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Query
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// WMI Property ScriptGuid
        /// </summary>
        public string ScriptGuid { get; set; }
        /// <summary>
        /// WMI Property UserId
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
