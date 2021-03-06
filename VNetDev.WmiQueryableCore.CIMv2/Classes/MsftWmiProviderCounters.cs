using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Msft_WmiProvider_Counters
    /// </summary>
    [WmiClass(Name = "Msft_WmiProvider_Counters")]
    public class MsftWmiProviderCounters
    {
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
    }
}