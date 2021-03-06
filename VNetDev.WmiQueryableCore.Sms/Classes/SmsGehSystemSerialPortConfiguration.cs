using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_SERIAL_PORT_CONFIGURATION
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_SERIAL_PORT_CONFIGURATION")]
    public class SmsGehSystemSerialPortConfiguration
    {
        /// <summary>
        /// WMI Property AbortReadWriteOnError
        /// </summary>
        public uint AbortReadWriteOnError { get; set; }
        /// <summary>
        /// WMI Property BaudRate
        /// </summary>
        public uint BaudRate { get; set; }
        /// <summary>
        /// WMI Property BinaryModeEnabled
        /// </summary>
        public uint BinaryModeEnabled { get; set; }
        /// <summary>
        /// WMI Property BitsPerByte
        /// </summary>
        public uint BitsPerByte { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property ContinueXMitOnXOff
        /// </summary>
        public uint ContinueXMitOnXOff { get; set; }
        /// <summary>
        /// WMI Property CTSOutflowControl
        /// </summary>
        public uint CtsOutflowControl { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DiscardNULLBytes
        /// </summary>
        public uint DiscardNullBytes { get; set; }
        /// <summary>
        /// WMI Property DSROutflowControl
        /// </summary>
        public uint DsrOutflowControl { get; set; }
        /// <summary>
        /// WMI Property DSRSensitivity
        /// </summary>
        public uint DsrSensitivity { get; set; }
        /// <summary>
        /// WMI Property DTRFlowControlType
        /// </summary>
        public string DtrFlowControlType { get; set; }
        /// <summary>
        /// WMI Property EOFCharacter
        /// </summary>
        public uint EofCharacter { get; set; }
        /// <summary>
        /// WMI Property ErrorReplaceCharacter
        /// </summary>
        public uint ErrorReplaceCharacter { get; set; }
        /// <summary>
        /// WMI Property ErrorReplacementEnabled
        /// </summary>
        public uint ErrorReplacementEnabled { get; set; }
        /// <summary>
        /// WMI Property EventCharacter
        /// </summary>
        public uint EventCharacter { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IsBusy
        /// </summary>
        public uint IsBusy { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Parity
        /// </summary>
        public string Parity { get; set; }
        /// <summary>
        /// WMI Property ParityCheckEnabled
        /// </summary>
        public uint ParityCheckEnabled { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property RTSFlowControlType
        /// </summary>
        public string RtsFlowControlType { get; set; }
        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
        /// <summary>
        /// WMI Property StopBits
        /// </summary>
        public string StopBits { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property XOffCharacter
        /// </summary>
        public uint XOffCharacter { get; set; }
        /// <summary>
        /// WMI Property XOffXMitThreshold
        /// </summary>
        public uint XOffXMitThreshold { get; set; }
        /// <summary>
        /// WMI Property XOnCharacter
        /// </summary>
        public uint XOnCharacter { get; set; }
        /// <summary>
        /// WMI Property XOnXMitThreshold
        /// </summary>
        public uint XOnXMitThreshold { get; set; }
        /// <summary>
        /// WMI Property XOnXOffInFlowControl
        /// </summary>
        public uint XOnXOffInFlowControl { get; set; }
        /// <summary>
        /// WMI Property XOnXOffOutFlowControl
        /// </summary>
        public uint XOnXOffOutFlowControl { get; set; }
    }
}
