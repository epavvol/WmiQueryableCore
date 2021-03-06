using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_POWER_MANAGEMENT_DAY
    /// </summary>
    [WmiClass(Name = "SMS_G_System_POWER_MANAGEMENT_DAY")]
    public class SmsGSystemPowerManagementDay
    {
        /// <summary>
        /// WMI Property Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property hr0_1
        /// </summary>
        [WmiProperty(Name = "hr0_1")]
        public uint Hr01 { get; set; }
        /// <summary>
        /// WMI Property hr10_11
        /// </summary>
        [WmiProperty(Name = "hr10_11")]
        public uint Hr1011 { get; set; }
        /// <summary>
        /// WMI Property hr11_12
        /// </summary>
        [WmiProperty(Name = "hr11_12")]
        public uint Hr1112 { get; set; }
        /// <summary>
        /// WMI Property hr12_13
        /// </summary>
        [WmiProperty(Name = "hr12_13")]
        public uint Hr1213 { get; set; }
        /// <summary>
        /// WMI Property hr13_14
        /// </summary>
        [WmiProperty(Name = "hr13_14")]
        public uint Hr1314 { get; set; }
        /// <summary>
        /// WMI Property hr14_15
        /// </summary>
        [WmiProperty(Name = "hr14_15")]
        public uint Hr1415 { get; set; }
        /// <summary>
        /// WMI Property hr15_16
        /// </summary>
        [WmiProperty(Name = "hr15_16")]
        public uint Hr1516 { get; set; }
        /// <summary>
        /// WMI Property hr16_17
        /// </summary>
        [WmiProperty(Name = "hr16_17")]
        public uint Hr1617 { get; set; }
        /// <summary>
        /// WMI Property hr17_18
        /// </summary>
        [WmiProperty(Name = "hr17_18")]
        public uint Hr1718 { get; set; }
        /// <summary>
        /// WMI Property hr18_19
        /// </summary>
        [WmiProperty(Name = "hr18_19")]
        public uint Hr1819 { get; set; }
        /// <summary>
        /// WMI Property hr19_20
        /// </summary>
        [WmiProperty(Name = "hr19_20")]
        public uint Hr1920 { get; set; }
        /// <summary>
        /// WMI Property hr1_2
        /// </summary>
        [WmiProperty(Name = "hr1_2")]
        public uint Hr12 { get; set; }
        /// <summary>
        /// WMI Property hr20_21
        /// </summary>
        [WmiProperty(Name = "hr20_21")]
        public uint Hr2021 { get; set; }
        /// <summary>
        /// WMI Property hr21_22
        /// </summary>
        [WmiProperty(Name = "hr21_22")]
        public uint Hr2122 { get; set; }
        /// <summary>
        /// WMI Property hr22_23
        /// </summary>
        [WmiProperty(Name = "hr22_23")]
        public uint Hr2223 { get; set; }
        /// <summary>
        /// WMI Property hr23_0
        /// </summary>
        [WmiProperty(Name = "hr23_0")]
        public uint Hr230 { get; set; }
        /// <summary>
        /// WMI Property hr2_3
        /// </summary>
        [WmiProperty(Name = "hr2_3")]
        public uint Hr23 { get; set; }
        /// <summary>
        /// WMI Property hr3_4
        /// </summary>
        [WmiProperty(Name = "hr3_4")]
        public uint Hr34 { get; set; }
        /// <summary>
        /// WMI Property hr4_5
        /// </summary>
        [WmiProperty(Name = "hr4_5")]
        public uint Hr45 { get; set; }
        /// <summary>
        /// WMI Property hr5_6
        /// </summary>
        [WmiProperty(Name = "hr5_6")]
        public uint Hr56 { get; set; }
        /// <summary>
        /// WMI Property hr6_7
        /// </summary>
        [WmiProperty(Name = "hr6_7")]
        public uint Hr67 { get; set; }
        /// <summary>
        /// WMI Property hr7_8
        /// </summary>
        [WmiProperty(Name = "hr7_8")]
        public uint Hr78 { get; set; }
        /// <summary>
        /// WMI Property hr8_9
        /// </summary>
        [WmiProperty(Name = "hr8_9")]
        public uint Hr89 { get; set; }
        /// <summary>
        /// WMI Property hr9_10
        /// </summary>
        [WmiProperty(Name = "hr9_10")]
        public uint Hr910 { get; set; }
        /// <summary>
        /// WMI Property minutesTotal
        /// </summary>
        public uint MinutesTotal { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TypeOfEvent
        /// </summary>
        public string TypeOfEvent { get; set; }
    }
}
