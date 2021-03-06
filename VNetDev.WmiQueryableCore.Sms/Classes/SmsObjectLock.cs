using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ObjectLock
    /// </summary>
    [WmiClass(Name = "SMS_ObjectLock")]
    public class SmsObjectLock
    {
        /// <summary>
        /// WMI static method <c>RequestLock</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectRelPath">WMI Property <c>ObjectRelPath</c> of type <c>string</c>.</param>
        /// <param name="requestTransfer">WMI Property <c>RequestTransfer</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestLockDelegate(WmiContext wmiContext, string objectRelPath = default, bool requestTransfer = default);
        /// <summary>
        /// WMI static method <c>RequestLock</c>.
        /// </summary>
        public static RequestLockDelegate RequestLock;
        
        /// <summary>
        /// WMI static method <c>RequestLockAsync</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectRelPath">WMI Property <c>ObjectRelPath</c> of type <c>string</c>.</param>
        /// <param name="requestTransfer">WMI Property <c>RequestTransfer</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestLockAsyncDelegate(WmiContext wmiContext, string objectRelPath = default, bool requestTransfer = default);
        /// <summary>
        /// WMI static method <c>RequestLockAsync</c>.
        /// </summary>
        public static RequestLockAsyncDelegate RequestLockAsync;
        
        /// <summary>
        /// WMI static method <c>CancelLockRequest</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="requestId">WMI Property <c>RequestID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CancelLockRequestDelegate(WmiContext wmiContext, string requestId = default);
        /// <summary>
        /// WMI static method <c>CancelLockRequest</c>.
        /// </summary>
        public static CancelLockRequestDelegate CancelLockRequest;
        
        /// <summary>
        /// WMI static method <c>ReleaseLock</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectRelPath">WMI Property <c>ObjectRelPath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReleaseLockDelegate(WmiContext wmiContext, string objectRelPath = default);
        /// <summary>
        /// WMI static method <c>ReleaseLock</c>.
        /// </summary>
        public static ReleaseLockDelegate ReleaseLock;
        
        /// <summary>
        /// WMI static method <c>ReleaseAllLocks</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReleaseAllLocksDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>ReleaseAllLocks</c>.
        /// </summary>
        public static ReleaseAllLocksDelegate ReleaseAllLocks;
        
        /// <summary>
        /// WMI static method <c>CheckLockRequest</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="requestId">WMI Property <c>RequestID</c> of type <c>string</c>.</param>
        /// <param name="timeout">WMI Property <c>Timeout</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CheckLockRequestDelegate(WmiContext wmiContext, string requestId = default, uint timeout = default);
        /// <summary>
        /// WMI static method <c>CheckLockRequest</c>.
        /// </summary>
        public static CheckLockRequestDelegate CheckLockRequest;
        
        /// <summary>
        /// WMI static method <c>GetLockInformation</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectRelPath">WMI Property <c>ObjectRelPath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetLockInformationDelegate(WmiContext wmiContext, string objectRelPath = default);
        /// <summary>
        /// WMI static method <c>GetLockInformation</c>.
        /// </summary>
        public static GetLockInformationDelegate GetLockInformation;
        
        /// <summary>
        /// WMI static method <c>RequestLocks</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectRelPaths">WMI Property <c>ObjectRelPaths</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="requestTransfer">WMI Property <c>RequestTransfer</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestLocksDelegate(WmiContext wmiContext, ICollection<string> objectRelPaths = default, bool requestTransfer = default);
        /// <summary>
        /// WMI static method <c>RequestLocks</c>.
        /// </summary>
        public static RequestLocksDelegate RequestLocks;
        
        /// <summary>
        /// WMI static method <c>RequestLocksAsync</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectRelPaths">WMI Property <c>ObjectRelPaths</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="requestTransfer">WMI Property <c>RequestTransfer</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestLocksAsyncDelegate(WmiContext wmiContext, ICollection<string> objectRelPaths = default, bool requestTransfer = default);
        /// <summary>
        /// WMI static method <c>RequestLocksAsync</c>.
        /// </summary>
        public static RequestLocksAsyncDelegate RequestLocksAsync;
        
        /// <summary>
        /// WMI static method <c>ReleaseLocks</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="objectRelPaths">WMI Property <c>ObjectRelPaths</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReleaseLocksDelegate(WmiContext wmiContext, ICollection<string> objectRelPaths = default);
        /// <summary>
        /// WMI static method <c>ReleaseLocks</c>.
        /// </summary>
        public static ReleaseLocksDelegate ReleaseLocks;
        
        /// <summary>
        /// WMI static method <c>CheckLockRequests</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="requestIDs">WMI Property <c>RequestIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="timeout">WMI Property <c>Timeout</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CheckLockRequestsDelegate(WmiContext wmiContext, ICollection<string> requestIDs = default, uint timeout = default);
        /// <summary>
        /// WMI static method <c>CheckLockRequests</c>.
        /// </summary>
        public static CheckLockRequestsDelegate CheckLockRequests;
        
        /// <summary>
        /// WMI static method <c>CancelLockRequests</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="requestIDs">WMI Property <c>RequestIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CancelLockRequestsDelegate(WmiContext wmiContext, ICollection<string> requestIDs = default);
        /// <summary>
        /// WMI static method <c>CancelLockRequests</c>.
        /// </summary>
        public static CancelLockRequestsDelegate CancelLockRequests;
    }
}
