using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Msft_Providers
    /// </summary>
    [WmiClass(Name = "Msft_Providers")]
    public class MsftProviders
    {
        /// <summary>
        /// WMI static method <c>Load</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="locale">WMI Property <c>Locale</c> of type <c>string</c>.</param>
        /// <param name="nameSpace">WMI Property <c>Namespace</c> of type <c>string</c>.</param>
        /// <param name="provider">WMI Property <c>provider</c> of type <c>string</c>.</param>
        /// <param name="transactionIdentifier">WMI Property <c>TransactionIdentifier</c> of type <c>string</c>.</param>
        /// <param name="user">WMI Property <c>User</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint LoadDelegate(WmiContext wmiContext, string locale = default, string nameSpace = default,
            string provider = default, string transactionIdentifier = default, string user = default);

        /// <summary>
        /// WMI method <c>Resume</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResumeDelegate();

        /// <summary>
        /// WMI method <c>Suspend</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SuspendDelegate();

        /// <summary>
        /// WMI method <c>UnLoad</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint UnLoadDelegate();

        /// <summary>
        /// WMI static method <c>Load</c>.
        /// </summary>
        public static LoadDelegate Load;

        /// <summary>
        /// WMI method <c>Resume</c>.
        /// </summary>
        public ResumeDelegate Resume;

        /// <summary>
        /// WMI method <c>Suspend</c>.
        /// </summary>
        public SuspendDelegate Suspend;

        /// <summary>
        /// WMI method <c>UnLoad</c>.
        /// </summary>
        public UnLoadDelegate UnLoad;

        /// <summary>
        /// WMI Property HostingGroup
        /// </summary>
        public string HostingGroup { get; set; }

        /// <summary>
        /// WMI Property HostingSpecification
        /// </summary>
        public uint HostingSpecification { get; set; }

        /// <summary>
        /// WMI Property HostProcessIdentifier
        /// </summary>
        public uint HostProcessIdentifier { get; set; }

        /// <summary>
        /// WMI Property Locale
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// WMI Property Namespace
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// WMI Property provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_AccessCheck
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_AccessCheck")]
        public ulong ProviderOperationAccessCheck { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_CancelQuery
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_CancelQuery")]
        public ulong ProviderOperationCancelQuery { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_CreateClassEnumAsync
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_CreateClassEnumAsync")]
        public ulong ProviderOperationCreateClassEnumAsync { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_CreateInstanceEnumAsync
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_CreateInstanceEnumAsync")]
        public ulong ProviderOperationCreateInstanceEnumAsync { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_CreateRefreshableEnum
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_CreateRefreshableEnum")]
        public ulong ProviderOperationCreateRefreshableEnum { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_CreateRefreshableObject
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_CreateRefreshableObject")]
        public ulong ProviderOperationCreateRefreshableObject { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_CreateRefresher
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_CreateRefresher")]
        public ulong ProviderOperationCreateRefresher { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_DeleteClassAsync
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_DeleteClassAsync")]
        public ulong ProviderOperationDeleteClassAsync { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_DeleteInstanceAsync
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_DeleteInstanceAsync")]
        public ulong ProviderOperationDeleteInstanceAsync { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_ExecMethodAsync
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_ExecMethodAsync")]
        public ulong ProviderOperationExecMethodAsync { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_ExecQueryAsync
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_ExecQueryAsync")]
        public ulong ProviderOperationExecQueryAsync { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_FindConsumer
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_FindConsumer")]
        public ulong ProviderOperationFindConsumer { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_GetObjectAsync
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_GetObjectAsync")]
        public ulong ProviderOperationGetObjectAsync { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_GetObjects
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_GetObjects")]
        public ulong ProviderOperationGetObjects { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_GetProperty
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_GetProperty")]
        public ulong ProviderOperationGetProperty { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_NewQuery
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_NewQuery")]
        public ulong ProviderOperationNewQuery { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_ProvideEvents
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_ProvideEvents")]
        public ulong ProviderOperationProvideEvents { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_PutClassAsync
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_PutClassAsync")]
        public ulong ProviderOperationPutClassAsync { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_PutInstanceAsync
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_PutInstanceAsync")]
        public ulong ProviderOperationPutInstanceAsync { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_PutProperty
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_PutProperty")]
        public ulong ProviderOperationPutProperty { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_QueryInstances
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_QueryInstances")]
        public ulong ProviderOperationQueryInstances { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_SetRegistrationObject
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_SetRegistrationObject")]
        public ulong ProviderOperationSetRegistrationObject { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_StopRefreshing
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_StopRefreshing")]
        public ulong ProviderOperationStopRefreshing { get; set; }

        /// <summary>
        /// WMI Property ProviderOperation_ValidateSubscription
        /// </summary>
        [WmiProperty(Name = "ProviderOperation_ValidateSubscription")]
        public ulong ProviderOperationValidateSubscription { get; set; }

        /// <summary>
        /// WMI Property TransactionIdentifier
        /// </summary>
        public string TransactionIdentifier { get; set; }

        /// <summary>
        /// WMI Property User
        /// </summary>
        public string User { get; set; }
    }
}