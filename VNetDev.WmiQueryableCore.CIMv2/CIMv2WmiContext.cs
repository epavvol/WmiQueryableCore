using VNetDev.WmiQueryableCore.CIMv2.Classes;

namespace VNetDev.WmiQueryableCore.CIMv2
{
    /// <summary>
    /// Representation of WMI namespace <c>ROOT\CIMV2</c>
    /// </summary>
    public class CIMv2WmiContext : WmiContext
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CIMv2WmiContext()
        {
        }

        /// <summary>
        /// Constructor allows to set WmiContextOptions object during context initialization.
        /// </summary>
        /// <param name="options">Preconfigured WmiContextOptions object</param>
        public CIMv2WmiContext(WmiContextOptions options) : base(options)
        {
        }

        #endregion

        /// <summary>
        /// Representation of WMI class <c>CIM_Action</c> collection
        /// </summary>
        public WmiClassSet<CimAction> CimAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ActionSequence</c> collection
        /// </summary>
        public WmiClassSet<CimActionSequence> CimActionSequence { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ActsAsSpare</c> collection
        /// </summary>
        public WmiClassSet<CimActsAsSpare> CimActsAsSpare { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AdjacentSlots</c> collection
        /// </summary>
        public WmiClassSet<CimAdjacentSlots> CimAdjacentSlots { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AggregatePExtent</c> collection
        /// </summary>
        public WmiClassSet<CimAggregatePExtent> CimAggregatePExtent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AggregatePSExtent</c> collection
        /// </summary>
        public WmiClassSet<CimAggregatePsExtent> CimAggregatePsExtent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AggregateRedundancyComponent</c> collection
        /// </summary>
        public WmiClassSet<CimAggregateRedundancyComponent> CimAggregateRedundancyComponent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AlarmDevice</c> collection
        /// </summary>
        public WmiClassSet<CimAlarmDevice> CimAlarmDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AllocatedResource</c> collection
        /// </summary>
        public WmiClassSet<CimAllocatedResource> CimAllocatedResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ApplicationSystem</c> collection
        /// </summary>
        public WmiClassSet<CimApplicationSystem> CimApplicationSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ApplicationSystemSoftwareFeature</c> collection
        /// </summary>
        public WmiClassSet<CimApplicationSystemSoftwareFeature> CimApplicationSystemSoftwareFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AssociatedAlarm</c> collection
        /// </summary>
        public WmiClassSet<CimAssociatedAlarm> CimAssociatedAlarm { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AssociatedBattery</c> collection
        /// </summary>
        public WmiClassSet<CimAssociatedBattery> CimAssociatedBattery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AssociatedCooling</c> collection
        /// </summary>
        public WmiClassSet<CimAssociatedCooling> CimAssociatedCooling { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AssociatedMemory</c> collection
        /// </summary>
        public WmiClassSet<CimAssociatedMemory> CimAssociatedMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AssociatedProcessorMemory</c> collection
        /// </summary>
        public WmiClassSet<CimAssociatedProcessorMemory> CimAssociatedProcessorMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AssociatedSensor</c> collection
        /// </summary>
        public WmiClassSet<CimAssociatedSensor> CimAssociatedSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AssociatedSupplyCurrentSensor</c> collection
        /// </summary>
        public WmiClassSet<CimAssociatedSupplyCurrentSensor> CimAssociatedSupplyCurrentSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_AssociatedSupplyVoltageSensor</c> collection
        /// </summary>
        public WmiClassSet<CimAssociatedSupplyVoltageSensor> CimAssociatedSupplyVoltageSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BasedOn</c> collection
        /// </summary>
        public WmiClassSet<CimBasedOn> CimBasedOn { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Battery</c> collection
        /// </summary>
        public WmiClassSet<CimBattery> CimBattery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BinarySensor</c> collection
        /// </summary>
        public WmiClassSet<CimBinarySensor> CimBinarySensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BIOSElement</c> collection
        /// </summary>
        public WmiClassSet<CimBiosElement> CimBiosElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BIOSFeature</c> collection
        /// </summary>
        public WmiClassSet<CimBiosFeature> CimBiosFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BIOSFeatureBIOSElements</c> collection
        /// </summary>
        public WmiClassSet<CimBiosFeatureBiosElements> CimBiosFeatureBiosElements { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BIOSLoadedInNV</c> collection
        /// </summary>
        public WmiClassSet<CimBiosLoadedInNv> CimBiosLoadedInNv { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BootOSFromFS</c> collection
        /// </summary>
        public WmiClassSet<CimBootOsFromFs> CimBootOsFromFs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BootSAP</c> collection
        /// </summary>
        public WmiClassSet<CimBootSap> CimBootSap { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BootService</c> collection
        /// </summary>
        public WmiClassSet<CimBootService> CimBootService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_BootServiceAccessBySAP</c> collection
        /// </summary>
        public WmiClassSet<CimBootServiceAccessBySap> CimBootServiceAccessBySap { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CacheMemory</c> collection
        /// </summary>
        public WmiClassSet<CimCacheMemory> CimCacheMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Card</c> collection
        /// </summary>
        public WmiClassSet<CimCard> CimCard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CardInSlot</c> collection
        /// </summary>
        public WmiClassSet<CimCardInSlot> CimCardInSlot { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CardOnCard</c> collection
        /// </summary>
        public WmiClassSet<CimCardOnCard> CimCardOnCard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CDROMDrive</c> collection
        /// </summary>
        public WmiClassSet<CimCdromDrive> CimCdromDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Chassis</c> collection
        /// </summary>
        public WmiClassSet<CimChassis> CimChassis { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ChassisInRack</c> collection
        /// </summary>
        public WmiClassSet<CimChassisInRack> CimChassisInRack { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Check</c> collection
        /// </summary>
        public WmiClassSet<CimCheck> CimCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Chip</c> collection
        /// </summary>
        public WmiClassSet<CimChip> CimChip { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ClassCreation</c> collection
        /// </summary>
        public WmiClassSet<CimClassCreation> CimClassCreation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ClassDeletion</c> collection
        /// </summary>
        public WmiClassSet<CimClassDeletion> CimClassDeletion { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ClassIndication</c> collection
        /// </summary>
        public WmiClassSet<CimClassIndication> CimClassIndication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ClassModification</c> collection
        /// </summary>
        public WmiClassSet<CimClassModification> CimClassModification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ClusteringSAP</c> collection
        /// </summary>
        public WmiClassSet<CimClusteringSap> CimClusteringSap { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ClusteringService</c> collection
        /// </summary>
        public WmiClassSet<CimClusteringService> CimClusteringService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ClusterServiceAccessBySAP</c> collection
        /// </summary>
        public WmiClassSet<CimClusterServiceAccessBySap> CimClusterServiceAccessBySap { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CollectedCollections</c> collection
        /// </summary>
        public WmiClassSet<CimCollectedCollections> CimCollectedCollections { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CollectedMSEs</c> collection
        /// </summary>
        public WmiClassSet<CimCollectedMsEs> CimCollectedMsEs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CollectionOfMSEs</c> collection
        /// </summary>
        public WmiClassSet<CimCollectionOfMsEs> CimCollectionOfMsEs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CollectionOfSensors</c> collection
        /// </summary>
        public WmiClassSet<CimCollectionOfSensors> CimCollectionOfSensors { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CollectionSetting</c> collection
        /// </summary>
        public WmiClassSet<CimCollectionSetting> CimCollectionSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CompatibleProduct</c> collection
        /// </summary>
        public WmiClassSet<CimCompatibleProduct> CimCompatibleProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Component</c> collection
        /// </summary>
        public WmiClassSet<CimComponent> CimComponent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ComputerSystem</c> collection
        /// </summary>
        public WmiClassSet<CimComputerSystem> CimComputerSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ComputerSystemDMA</c> collection
        /// </summary>
        public WmiClassSet<CimComputerSystemDma> CimComputerSystemDma { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ComputerSystemIRQ</c> collection
        /// </summary>
        public WmiClassSet<CimComputerSystemIrq> CimComputerSystemIrq { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ComputerSystemMappedIO</c> collection
        /// </summary>
        public WmiClassSet<CimComputerSystemMappedIo> CimComputerSystemMappedIo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ComputerSystemPackage</c> collection
        /// </summary>
        public WmiClassSet<CimComputerSystemPackage> CimComputerSystemPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ComputerSystemResource</c> collection
        /// </summary>
        public WmiClassSet<CimComputerSystemResource> CimComputerSystemResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Configuration</c> collection
        /// </summary>
        public WmiClassSet<CimConfiguration> CimConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ConnectedTo</c> collection
        /// </summary>
        public WmiClassSet<CimConnectedTo> CimConnectedTo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ConnectorOnPackage</c> collection
        /// </summary>
        public WmiClassSet<CimConnectorOnPackage> CimConnectorOnPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Container</c> collection
        /// </summary>
        public WmiClassSet<CimContainer> CimContainer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ControlledBy</c> collection
        /// </summary>
        public WmiClassSet<CimControlledBy> CimControlledBy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Controller</c> collection
        /// </summary>
        public WmiClassSet<CimController> CimController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CoolingDevice</c> collection
        /// </summary>
        public WmiClassSet<CimCoolingDevice> CimCoolingDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CopyFileAction</c> collection
        /// </summary>
        public WmiClassSet<CimCopyFileAction> CimCopyFileAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CreateDirectoryAction</c> collection
        /// </summary>
        public WmiClassSet<CimCreateDirectoryAction> CimCreateDirectoryAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_CurrentSensor</c> collection
        /// </summary>
        public WmiClassSet<CimCurrentSensor> CimCurrentSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DataFile</c> collection
        /// </summary>
        public WmiClassSet<CimDataFile> CimDataFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Dependency</c> collection
        /// </summary>
        public WmiClassSet<CimDependency> CimDependency { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DependencyContext</c> collection
        /// </summary>
        public WmiClassSet<CimDependencyContext> CimDependencyContext { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DesktopMonitor</c> collection
        /// </summary>
        public WmiClassSet<CimDesktopMonitor> CimDesktopMonitor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DeviceAccessedByFile</c> collection
        /// </summary>
        public WmiClassSet<CimDeviceAccessedByFile> CimDeviceAccessedByFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DeviceConnection</c> collection
        /// </summary>
        public WmiClassSet<CimDeviceConnection> CimDeviceConnection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DeviceErrorCounts</c> collection
        /// </summary>
        public WmiClassSet<CimDeviceErrorCounts> CimDeviceErrorCounts { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DeviceFile</c> collection
        /// </summary>
        public WmiClassSet<CimDeviceFile> CimDeviceFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DeviceSAPImplementation</c> collection
        /// </summary>
        public WmiClassSet<CimDeviceSapImplementation> CimDeviceSapImplementation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DeviceServiceImplementation</c> collection
        /// </summary>
        public WmiClassSet<CimDeviceServiceImplementation> CimDeviceServiceImplementation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DeviceSoftware</c> collection
        /// </summary>
        public WmiClassSet<CimDeviceSoftware> CimDeviceSoftware { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Directory</c> collection
        /// </summary>
        public WmiClassSet<CimDirectory> CimDirectory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DirectoryAction</c> collection
        /// </summary>
        public WmiClassSet<CimDirectoryAction> CimDirectoryAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DirectoryContainsFile</c> collection
        /// </summary>
        public WmiClassSet<CimDirectoryContainsFile> CimDirectoryContainsFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DirectorySpecification</c> collection
        /// </summary>
        public WmiClassSet<CimDirectorySpecification> CimDirectorySpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DirectorySpecificationFile</c> collection
        /// </summary>
        public WmiClassSet<CimDirectorySpecificationFile> CimDirectorySpecificationFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DiscreteSensor</c> collection
        /// </summary>
        public WmiClassSet<CimDiscreteSensor> CimDiscreteSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DiskDrive</c> collection
        /// </summary>
        public WmiClassSet<CimDiskDrive> CimDiskDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DisketteDrive</c> collection
        /// </summary>
        public WmiClassSet<CimDisketteDrive> CimDisketteDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DiskPartition</c> collection
        /// </summary>
        public WmiClassSet<CimDiskPartition> CimDiskPartition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DiskSpaceCheck</c> collection
        /// </summary>
        public WmiClassSet<CimDiskSpaceCheck> CimDiskSpaceCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Display</c> collection
        /// </summary>
        public WmiClassSet<CimDisplay> CimDisplay { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_DMA</c> collection
        /// </summary>
        public WmiClassSet<CimDma> CimDma { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Docked</c> collection
        /// </summary>
        public WmiClassSet<CimDocked> CimDocked { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ElementCapacity</c> collection
        /// </summary>
        public WmiClassSet<CimElementCapacity> CimElementCapacity { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ElementConfiguration</c> collection
        /// </summary>
        public WmiClassSet<CimElementConfiguration> CimElementConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ElementSetting</c> collection
        /// </summary>
        public WmiClassSet<CimElementSetting> CimElementSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ElementsLinked</c> collection
        /// </summary>
        public WmiClassSet<CimElementsLinked> CimElementsLinked { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Error</c> collection
        /// </summary>
        public WmiClassSet<CimError> CimError { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ErrorCountersForDevice</c> collection
        /// </summary>
        public WmiClassSet<CimErrorCountersForDevice> CimErrorCountersForDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ExecuteProgram</c> collection
        /// </summary>
        public WmiClassSet<CimExecuteProgram> CimExecuteProgram { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Export</c> collection
        /// </summary>
        public WmiClassSet<CimExport> CimExport { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ExtraCapacityGroup</c> collection
        /// </summary>
        public WmiClassSet<CimExtraCapacityGroup> CimExtraCapacityGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Fan</c> collection
        /// </summary>
        public WmiClassSet<CimFan> CimFan { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FileAction</c> collection
        /// </summary>
        public WmiClassSet<CimFileAction> CimFileAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FileSpecification</c> collection
        /// </summary>
        public WmiClassSet<CimFileSpecification> CimFileSpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FileStorage</c> collection
        /// </summary>
        public WmiClassSet<CimFileStorage> CimFileStorage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FileSystem</c> collection
        /// </summary>
        public WmiClassSet<CimFileSystem> CimFileSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FlatPanel</c> collection
        /// </summary>
        public WmiClassSet<CimFlatPanel> CimFlatPanel { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FromDirectoryAction</c> collection
        /// </summary>
        public WmiClassSet<CimFromDirectoryAction> CimFromDirectoryAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FromDirectorySpecification</c> collection
        /// </summary>
        public WmiClassSet<CimFromDirectorySpecification> CimFromDirectorySpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FRU</c> collection
        /// </summary>
        public WmiClassSet<CimFru> CimFru { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FRUIncludesProduct</c> collection
        /// </summary>
        public WmiClassSet<CimFruIncludesProduct> CimFruIncludesProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_FRUPhysicalElements</c> collection
        /// </summary>
        public WmiClassSet<CimFruPhysicalElements> CimFruPhysicalElements { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_HeatPipe</c> collection
        /// </summary>
        public WmiClassSet<CimHeatPipe> CimHeatPipe { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_HostedAccessPoint</c> collection
        /// </summary>
        public WmiClassSet<CimHostedAccessPoint> CimHostedAccessPoint { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_HostedBootSAP</c> collection
        /// </summary>
        public WmiClassSet<CimHostedBootSap> CimHostedBootSap { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_HostedBootService</c> collection
        /// </summary>
        public WmiClassSet<CimHostedBootService> CimHostedBootService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_HostedFileSystem</c> collection
        /// </summary>
        public WmiClassSet<CimHostedFileSystem> CimHostedFileSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_HostedJobDestination</c> collection
        /// </summary>
        public WmiClassSet<CimHostedJobDestination> CimHostedJobDestination { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_HostedService</c> collection
        /// </summary>
        public WmiClassSet<CimHostedService> CimHostedService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Indication</c> collection
        /// </summary>
        public WmiClassSet<CimIndication> CimIndication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_InfraredController</c> collection
        /// </summary>
        public WmiClassSet<CimInfraredController> CimInfraredController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_InstalledOS</c> collection
        /// </summary>
        public WmiClassSet<CimInstalledOs> CimInstalledOs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_InstalledSoftwareElement</c> collection
        /// </summary>
        public WmiClassSet<CimInstalledSoftwareElement> CimInstalledSoftwareElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_InstCreation</c> collection
        /// </summary>
        public WmiClassSet<CimInstCreation> CimInstCreation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_InstDeletion</c> collection
        /// </summary>
        public WmiClassSet<CimInstDeletion> CimInstDeletion { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_InstIndication</c> collection
        /// </summary>
        public WmiClassSet<CimInstIndication> CimInstIndication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_InstModification</c> collection
        /// </summary>
        public WmiClassSet<CimInstModification> CimInstModification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_IRQ</c> collection
        /// </summary>
        public WmiClassSet<CimIrq> CimIrq { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Job</c> collection
        /// </summary>
        public WmiClassSet<CimJob> CimJob { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_JobDestination</c> collection
        /// </summary>
        public WmiClassSet<CimJobDestination> CimJobDestination { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_JobDestinationJobs</c> collection
        /// </summary>
        public WmiClassSet<CimJobDestinationJobs> CimJobDestinationJobs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Keyboard</c> collection
        /// </summary>
        public WmiClassSet<CimKeyboard> CimKeyboard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_LinkHasConnector</c> collection
        /// </summary>
        public WmiClassSet<CimLinkHasConnector> CimLinkHasConnector { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_LocalFileSystem</c> collection
        /// </summary>
        public WmiClassSet<CimLocalFileSystem> CimLocalFileSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Location</c> collection
        /// </summary>
        public WmiClassSet<CimLocation> CimLocation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_LogicalDevice</c> collection
        /// </summary>
        public WmiClassSet<CimLogicalDevice> CimLogicalDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_LogicalDisk</c> collection
        /// </summary>
        public WmiClassSet<CimLogicalDisk> CimLogicalDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_LogicalDiskBasedOnPartition</c> collection
        /// </summary>
        public WmiClassSet<CimLogicalDiskBasedOnPartition> CimLogicalDiskBasedOnPartition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_LogicalDiskBasedOnVolumeSet</c> collection
        /// </summary>
        public WmiClassSet<CimLogicalDiskBasedOnVolumeSet> CimLogicalDiskBasedOnVolumeSet { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_LogicalElement</c> collection
        /// </summary>
        public WmiClassSet<CimLogicalElement> CimLogicalElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_LogicalFile</c> collection
        /// </summary>
        public WmiClassSet<CimLogicalFile> CimLogicalFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_LogicalIdentity</c> collection
        /// </summary>
        public WmiClassSet<CimLogicalIdentity> CimLogicalIdentity { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MagnetoOpticalDrive</c> collection
        /// </summary>
        public WmiClassSet<CimMagnetoOpticalDrive> CimMagnetoOpticalDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ManagedSystemElement</c> collection
        /// </summary>
        public WmiClassSet<CimManagedSystemElement> CimManagedSystemElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ManagementController</c> collection
        /// </summary>
        public WmiClassSet<CimManagementController> CimManagementController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MediaAccessDevice</c> collection
        /// </summary>
        public WmiClassSet<CimMediaAccessDevice> CimMediaAccessDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MediaPresent</c> collection
        /// </summary>
        public WmiClassSet<CimMediaPresent> CimMediaPresent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Memory</c> collection
        /// </summary>
        public WmiClassSet<CimMemory> CimMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MemoryCapacity</c> collection
        /// </summary>
        public WmiClassSet<CimMemoryCapacity> CimMemoryCapacity { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MemoryCheck</c> collection
        /// </summary>
        public WmiClassSet<CimMemoryCheck> CimMemoryCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MemoryMappedIO</c> collection
        /// </summary>
        public WmiClassSet<CimMemoryMappedIo> CimMemoryMappedIo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MemoryOnCard</c> collection
        /// </summary>
        public WmiClassSet<CimMemoryOnCard> CimMemoryOnCard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MemoryWithMedia</c> collection
        /// </summary>
        public WmiClassSet<CimMemoryWithMedia> CimMemoryWithMedia { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ModifySettingAction</c> collection
        /// </summary>
        public WmiClassSet<CimModifySettingAction> CimModifySettingAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MonitorResolution</c> collection
        /// </summary>
        public WmiClassSet<CimMonitorResolution> CimMonitorResolution { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MonitorSetting</c> collection
        /// </summary>
        public WmiClassSet<CimMonitorSetting> CimMonitorSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Mount</c> collection
        /// </summary>
        public WmiClassSet<CimMount> CimMount { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_MultiStateSensor</c> collection
        /// </summary>
        public WmiClassSet<CimMultiStateSensor> CimMultiStateSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_NetworkAdapter</c> collection
        /// </summary>
        public WmiClassSet<CimNetworkAdapter> CimNetworkAdapter { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_NFS</c> collection
        /// </summary>
        public WmiClassSet<CimNfs> CimNfs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_NonVolatileStorage</c> collection
        /// </summary>
        public WmiClassSet<CimNonVolatileStorage> CimNonVolatileStorage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_NumericSensor</c> collection
        /// </summary>
        public WmiClassSet<CimNumericSensor> CimNumericSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_OperatingSystem</c> collection
        /// </summary>
        public WmiClassSet<CimOperatingSystem> CimOperatingSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_OperatingSystemSoftwareFeature</c> collection
        /// </summary>
        public WmiClassSet<CimOperatingSystemSoftwareFeature> CimOperatingSystemSoftwareFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_OSProcess</c> collection
        /// </summary>
        public WmiClassSet<CimOsProcess> CimOsProcess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_OSVersionCheck</c> collection
        /// </summary>
        public WmiClassSet<CimOsVersionCheck> CimOsVersionCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PackageAlarm</c> collection
        /// </summary>
        public WmiClassSet<CimPackageAlarm> CimPackageAlarm { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PackageCooling</c> collection
        /// </summary>
        public WmiClassSet<CimPackageCooling> CimPackageCooling { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PackagedComponent</c> collection
        /// </summary>
        public WmiClassSet<CimPackagedComponent> CimPackagedComponent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PackageInChassis</c> collection
        /// </summary>
        public WmiClassSet<CimPackageInChassis> CimPackageInChassis { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PackageInSlot</c> collection
        /// </summary>
        public WmiClassSet<CimPackageInSlot> CimPackageInSlot { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PackageTempSensor</c> collection
        /// </summary>
        public WmiClassSet<CimPackageTempSensor> CimPackageTempSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ParallelController</c> collection
        /// </summary>
        public WmiClassSet<CimParallelController> CimParallelController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ParticipatesInSet</c> collection
        /// </summary>
        public WmiClassSet<CimParticipatesInSet> CimParticipatesInSet { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PCIController</c> collection
        /// </summary>
        public WmiClassSet<CimPciController> CimPciController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PCMCIAController</c> collection
        /// </summary>
        public WmiClassSet<CimPcmciaController> CimPcmciaController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PCVideoController</c> collection
        /// </summary>
        public WmiClassSet<CimPcVideoController> CimPcVideoController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PExtentRedundancyComponent</c> collection
        /// </summary>
        public WmiClassSet<CimPExtentRedundancyComponent> CimPExtentRedundancyComponent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalCapacity</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalCapacity> CimPhysicalCapacity { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalComponent</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalComponent> CimPhysicalComponent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalConnector</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalConnector> CimPhysicalConnector { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalElement</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalElement> CimPhysicalElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalElementLocation</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalElementLocation> CimPhysicalElementLocation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalExtent</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalExtent> CimPhysicalExtent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalFrame</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalFrame> CimPhysicalFrame { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalLink</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalLink> CimPhysicalLink { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalMedia</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalMedia> CimPhysicalMedia { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalMemory</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalMemory> CimPhysicalMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PhysicalPackage</c> collection
        /// </summary>
        public WmiClassSet<CimPhysicalPackage> CimPhysicalPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PointingDevice</c> collection
        /// </summary>
        public WmiClassSet<CimPointingDevice> CimPointingDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PotsModem</c> collection
        /// </summary>
        public WmiClassSet<CimPotsModem> CimPotsModem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PowerSupply</c> collection
        /// </summary>
        public WmiClassSet<CimPowerSupply> CimPowerSupply { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Printer</c> collection
        /// </summary>
        public WmiClassSet<CimPrinter> CimPrinter { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Process</c> collection
        /// </summary>
        public WmiClassSet<CimProcess> CimProcess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ProcessExecutable</c> collection
        /// </summary>
        public WmiClassSet<CimProcessExecutable> CimProcessExecutable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Processor</c> collection
        /// </summary>
        public WmiClassSet<CimProcessor> CimProcessor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ProcessThread</c> collection
        /// </summary>
        public WmiClassSet<CimProcessThread> CimProcessThread { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Product</c> collection
        /// </summary>
        public WmiClassSet<CimProduct> CimProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ProductFRU</c> collection
        /// </summary>
        public WmiClassSet<CimProductFru> CimProductFru { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ProductParentChild</c> collection
        /// </summary>
        public WmiClassSet<CimProductParentChild> CimProductParentChild { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ProductPhysicalElements</c> collection
        /// </summary>
        public WmiClassSet<CimProductPhysicalElements> CimProductPhysicalElements { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ProductProductDependency</c> collection
        /// </summary>
        public WmiClassSet<CimProductProductDependency> CimProductProductDependency { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ProductSoftwareFeatures</c> collection
        /// </summary>
        public WmiClassSet<CimProductSoftwareFeatures> CimProductSoftwareFeatures { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ProductSupport</c> collection
        /// </summary>
        public WmiClassSet<CimProductSupport> CimProductSupport { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ProtectedSpaceExtent</c> collection
        /// </summary>
        public WmiClassSet<CimProtectedSpaceExtent> CimProtectedSpaceExtent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_PSExtentBasedOnPExtent</c> collection
        /// </summary>
        public WmiClassSet<CimPsExtentBasedOnPExtent> CimPsExtentBasedOnPExtent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Rack</c> collection
        /// </summary>
        public WmiClassSet<CimRack> CimRack { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Realizes</c> collection
        /// </summary>
        public WmiClassSet<CimRealizes> CimRealizes { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RealizesAggregatePExtent</c> collection
        /// </summary>
        public WmiClassSet<CimRealizesAggregatePExtent> CimRealizesAggregatePExtent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RealizesDiskPartition</c> collection
        /// </summary>
        public WmiClassSet<CimRealizesDiskPartition> CimRealizesDiskPartition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RealizesPExtent</c> collection
        /// </summary>
        public WmiClassSet<CimRealizesPExtent> CimRealizesPExtent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RebootAction</c> collection
        /// </summary>
        public WmiClassSet<CimRebootAction> CimRebootAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RedundancyComponent</c> collection
        /// </summary>
        public WmiClassSet<CimRedundancyComponent> CimRedundancyComponent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RedundancyGroup</c> collection
        /// </summary>
        public WmiClassSet<CimRedundancyGroup> CimRedundancyGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Refrigeration</c> collection
        /// </summary>
        public WmiClassSet<CimRefrigeration> CimRefrigeration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RelatedStatistics</c> collection
        /// </summary>
        public WmiClassSet<CimRelatedStatistics> CimRelatedStatistics { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RemoteFileSystem</c> collection
        /// </summary>
        public WmiClassSet<CimRemoteFileSystem> CimRemoteFileSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RemoveDirectoryAction</c> collection
        /// </summary>
        public WmiClassSet<CimRemoveDirectoryAction> CimRemoveDirectoryAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RemoveFileAction</c> collection
        /// </summary>
        public WmiClassSet<CimRemoveFileAction> CimRemoveFileAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ReplacementSet</c> collection
        /// </summary>
        public WmiClassSet<CimReplacementSet> CimReplacementSet { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ResidesOnExtent</c> collection
        /// </summary>
        public WmiClassSet<CimResidesOnExtent> CimResidesOnExtent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_RunningOS</c> collection
        /// </summary>
        public WmiClassSet<CimRunningOs> CimRunningOs { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SAPSAPDependency</c> collection
        /// </summary>
        public WmiClassSet<CimSapsapDependency> CimSapsapDependency { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Scanner</c> collection
        /// </summary>
        public WmiClassSet<CimScanner> CimScanner { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SCSIController</c> collection
        /// </summary>
        public WmiClassSet<CimScsiController> CimScsiController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SCSIInterface</c> collection
        /// </summary>
        public WmiClassSet<CimScsiInterface> CimScsiInterface { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Sensor</c> collection
        /// </summary>
        public WmiClassSet<CimSensor> CimSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SerialController</c> collection
        /// </summary>
        public WmiClassSet<CimSerialController> CimSerialController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SerialInterface</c> collection
        /// </summary>
        public WmiClassSet<CimSerialInterface> CimSerialInterface { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Service</c> collection
        /// </summary>
        public WmiClassSet<CimService> CimService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ServiceAccessBySAP</c> collection
        /// </summary>
        public WmiClassSet<CimServiceAccessBySap> CimServiceAccessBySap { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ServiceAccessPoint</c> collection
        /// </summary>
        public WmiClassSet<CimServiceAccessPoint> CimServiceAccessPoint { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ServiceSAPDependency</c> collection
        /// </summary>
        public WmiClassSet<CimServiceSapDependency> CimServiceSapDependency { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ServiceServiceDependency</c> collection
        /// </summary>
        public WmiClassSet<CimServiceServiceDependency> CimServiceServiceDependency { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Setting</c> collection
        /// </summary>
        public WmiClassSet<CimSetting> CimSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SettingCheck</c> collection
        /// </summary>
        public WmiClassSet<CimSettingCheck> CimSettingCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SettingContext</c> collection
        /// </summary>
        public WmiClassSet<CimSettingContext> CimSettingContext { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Slot</c> collection
        /// </summary>
        public WmiClassSet<CimSlot> CimSlot { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SlotInSlot</c> collection
        /// </summary>
        public WmiClassSet<CimSlotInSlot> CimSlotInSlot { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SoftwareElement</c> collection
        /// </summary>
        public WmiClassSet<CimSoftwareElement> CimSoftwareElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SoftwareElementActions</c> collection
        /// </summary>
        public WmiClassSet<CimSoftwareElementActions> CimSoftwareElementActions { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SoftwareElementChecks</c> collection
        /// </summary>
        public WmiClassSet<CimSoftwareElementChecks> CimSoftwareElementChecks { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SoftwareElementVersionCheck</c> collection
        /// </summary>
        public WmiClassSet<CimSoftwareElementVersionCheck> CimSoftwareElementVersionCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SoftwareFeature</c> collection
        /// </summary>
        public WmiClassSet<CimSoftwareFeature> CimSoftwareFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SoftwareFeatureSAPImplementation</c> collection
        /// </summary>
        public WmiClassSet<CimSoftwareFeatureSapImplementation> CimSoftwareFeatureSapImplementation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SoftwareFeatureServiceImplementation</c> collection
        /// </summary>
        public WmiClassSet<CimSoftwareFeatureServiceImplementation> CimSoftwareFeatureServiceImplementation
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>CIM_SoftwareFeatureSoftwareElements</c> collection
        /// </summary>
        public WmiClassSet<CimSoftwareFeatureSoftwareElements> CimSoftwareFeatureSoftwareElements { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SpareGroup</c> collection
        /// </summary>
        public WmiClassSet<CimSpareGroup> CimSpareGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_StatisticalInformation</c> collection
        /// </summary>
        public WmiClassSet<CimStatisticalInformation> CimStatisticalInformation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Statistics</c> collection
        /// </summary>
        public WmiClassSet<CimStatistics> CimStatistics { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_StorageDefect</c> collection
        /// </summary>
        public WmiClassSet<CimStorageDefect> CimStorageDefect { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_StorageError</c> collection
        /// </summary>
        public WmiClassSet<CimStorageError> CimStorageError { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_StorageExtent</c> collection
        /// </summary>
        public WmiClassSet<CimStorageExtent> CimStorageExtent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_StorageRedundancyGroup</c> collection
        /// </summary>
        public WmiClassSet<CimStorageRedundancyGroup> CimStorageRedundancyGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_StorageVolume</c> collection
        /// </summary>
        public WmiClassSet<CimStorageVolume> CimStorageVolume { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SupportAccess</c> collection
        /// </summary>
        public WmiClassSet<CimSupportAccess> CimSupportAccess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SwapSpaceCheck</c> collection
        /// </summary>
        public WmiClassSet<CimSwapSpaceCheck> CimSwapSpaceCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_System</c> collection
        /// </summary>
        public WmiClassSet<CimSystem> CimSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SystemComponent</c> collection
        /// </summary>
        public WmiClassSet<CimSystemComponent> CimSystemComponent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SystemDevice</c> collection
        /// </summary>
        public WmiClassSet<CimSystemDevice> CimSystemDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_SystemResource</c> collection
        /// </summary>
        public WmiClassSet<CimSystemResource> CimSystemResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Tachometer</c> collection
        /// </summary>
        public WmiClassSet<CimTachometer> CimTachometer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_TapeDrive</c> collection
        /// </summary>
        public WmiClassSet<CimTapeDrive> CimTapeDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_TemperatureSensor</c> collection
        /// </summary>
        public WmiClassSet<CimTemperatureSensor> CimTemperatureSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_Thread</c> collection
        /// </summary>
        public WmiClassSet<CimThread> CimThread { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ToDirectoryAction</c> collection
        /// </summary>
        public WmiClassSet<CimToDirectoryAction> CimToDirectoryAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_ToDirectorySpecification</c> collection
        /// </summary>
        public WmiClassSet<CimToDirectorySpecification> CimToDirectorySpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_UninterruptiblePowerSupply</c> collection
        /// </summary>
        public WmiClassSet<CimUninterruptiblePowerSupply> CimUninterruptiblePowerSupply { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_UnitaryComputerSystem</c> collection
        /// </summary>
        public WmiClassSet<CimUnitaryComputerSystem> CimUnitaryComputerSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_USBController</c> collection
        /// </summary>
        public WmiClassSet<CimUsbController> CimUsbController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_USBControllerHasHub</c> collection
        /// </summary>
        public WmiClassSet<CimUsbControllerHasHub> CimUsbControllerHasHub { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_USBDevice</c> collection
        /// </summary>
        public WmiClassSet<CimUsbDevice> CimUsbDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_USBHub</c> collection
        /// </summary>
        public WmiClassSet<CimUsbHub> CimUsbHub { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_UserDevice</c> collection
        /// </summary>
        public WmiClassSet<CimUserDevice> CimUserDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VersionCompatibilityCheck</c> collection
        /// </summary>
        public WmiClassSet<CimVersionCompatibilityCheck> CimVersionCompatibilityCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VideoBIOSElement</c> collection
        /// </summary>
        public WmiClassSet<CimVideoBiosElement> CimVideoBiosElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VideoBIOSFeature</c> collection
        /// </summary>
        public WmiClassSet<CimVideoBiosFeature> CimVideoBiosFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VideoBIOSFeatureVideoBIOSElements</c> collection
        /// </summary>
        public WmiClassSet<CimVideoBiosFeatureVideoBiosElements> CimVideoBiosFeatureVideoBiosElements { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VideoController</c> collection
        /// </summary>
        public WmiClassSet<CimVideoController> CimVideoController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VideoControllerResolution</c> collection
        /// </summary>
        public WmiClassSet<CimVideoControllerResolution> CimVideoControllerResolution { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VideoSetting</c> collection
        /// </summary>
        public WmiClassSet<CimVideoSetting> CimVideoSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VolatileStorage</c> collection
        /// </summary>
        public WmiClassSet<CimVolatileStorage> CimVolatileStorage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VoltageSensor</c> collection
        /// </summary>
        public WmiClassSet<CimVoltageSensor> CimVoltageSensor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_VolumeSet</c> collection
        /// </summary>
        public WmiClassSet<CimVolumeSet> CimVolumeSet { get; set; }

        /// <summary>
        /// Representation of WMI class <c>CIM_WORMDrive</c> collection
        /// </summary>
        public WmiClassSet<CimWormDrive> CimWormDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_ExtendedStatus</c> collection
        /// </summary>
        public WmiClassSet<MsftExtendedStatus> MsftExtendedStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NCProvAccessCheck</c> collection
        /// </summary>
        public WmiClassSet<MsftNcProvAccessCheck> MsftNcProvAccessCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NCProvCancelQuery</c> collection
        /// </summary>
        public WmiClassSet<MsftNcProvCancelQuery> MsftNcProvCancelQuery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NCProvClientConnected</c> collection
        /// </summary>
        public WmiClassSet<MsftNcProvClientConnected> MsftNcProvClientConnected { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NCProvEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftNcProvEvent> MsftNcProvEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NCProvNewQuery</c> collection
        /// </summary>
        public WmiClassSet<MsftNcProvNewQuery> MsftNcProvNewQuery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetBadAccount</c> collection
        /// </summary>
        public WmiClassSet<MsftNetBadAccount> MsftNetBadAccount { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetBadServiceState</c> collection
        /// </summary>
        public WmiClassSet<MsftNetBadServiceState> MsftNetBadServiceState { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetBootSystemDriversFailed</c> collection
        /// </summary>
        public WmiClassSet<MsftNetBootSystemDriversFailed> MsftNetBootSystemDriversFailed { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetCallToFunctionFailed</c> collection
        /// </summary>
        public WmiClassSet<MsftNetCallToFunctionFailed> MsftNetCallToFunctionFailed { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetCallToFunctionFailedII</c> collection
        /// </summary>
        public WmiClassSet<MsftNetCallToFunctionFailedIi> MsftNetCallToFunctionFailedIi { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetCircularDependencyAuto</c> collection
        /// </summary>
        public WmiClassSet<MsftNetCircularDependencyAuto> MsftNetCircularDependencyAuto { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetCircularDependencyDemand</c> collection
        /// </summary>
        public WmiClassSet<MsftNetCircularDependencyDemand> MsftNetCircularDependencyDemand { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetConnectionTimeout</c> collection
        /// </summary>
        public WmiClassSet<MsftNetConnectionTimeout> MsftNetConnectionTimeout { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetDependOnLaterGroup</c> collection
        /// </summary>
        public WmiClassSet<MsftNetDependOnLaterGroup> MsftNetDependOnLaterGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetDependOnLaterService</c> collection
        /// </summary>
        public WmiClassSet<MsftNetDependOnLaterService> MsftNetDependOnLaterService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetFirstLogonFailed</c> collection
        /// </summary>
        public WmiClassSet<MsftNetFirstLogonFailed> MsftNetFirstLogonFailed { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetFirstLogonFailedII</c> collection
        /// </summary>
        public WmiClassSet<MsftNetFirstLogonFailedIi> MsftNetFirstLogonFailedIi { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetReadfileTimeout</c> collection
        /// </summary>
        public WmiClassSet<MsftNetReadfileTimeout> MsftNetReadfileTimeout { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetRevertedToLastKnownGood</c> collection
        /// </summary>
        public WmiClassSet<MsftNetRevertedToLastKnownGood> MsftNetRevertedToLastKnownGood { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceConfigBackoutFailed</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceConfigBackoutFailed> MsftNetServiceConfigBackoutFailed { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceControlSuccess</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceControlSuccess> MsftNetServiceControlSuccess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceCrash</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceCrash> MsftNetServiceCrash { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceCrashNoAction</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceCrashNoAction> MsftNetServiceCrashNoAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceDifferentPIDConnected</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceDifferentPidConnected> MsftNetServiceDifferentPidConnected { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceExitFailed</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceExitFailed> MsftNetServiceExitFailed { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceExitFailedSpecific</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceExitFailedSpecific> MsftNetServiceExitFailedSpecific { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceLogonTypeNotGranted</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceLogonTypeNotGranted> MsftNetServiceLogonTypeNotGranted { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceNotInteractive</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceNotInteractive> MsftNetServiceNotInteractive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceRecoveryFailed</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceRecoveryFailed> MsftNetServiceRecoveryFailed { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceShutdownFailed</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceShutdownFailed> MsftNetServiceShutdownFailed { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceSlowStartup</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceSlowStartup> MsftNetServiceSlowStartup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceStartFailed</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceStartFailed> MsftNetServiceStartFailed { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceStartFailedGroup</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceStartFailedGroup> MsftNetServiceStartFailedGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceStartFailedII</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceStartFailedIi> MsftNetServiceStartFailedIi { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceStartFailedNone</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceStartFailedNone> MsftNetServiceStartFailedNone { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceStartHung</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceStartHung> MsftNetServiceStartHung { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceStartTypeChanged</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceStartTypeChanged> MsftNetServiceStartTypeChanged { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceStatusSuccess</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceStatusSuccess> MsftNetServiceStatusSuccess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetServiceStopControlSuccess</c> collection
        /// </summary>
        public WmiClassSet<MsftNetServiceStopControlSuccess> MsftNetServiceStopControlSuccess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetSevereServiceFailed</c> collection
        /// </summary>
        public WmiClassSet<MsftNetSevereServiceFailed> MsftNetSevereServiceFailed { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetTakeOwnership</c> collection
        /// </summary>
        public WmiClassSet<MsftNetTakeOwnership> MsftNetTakeOwnership { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetTransactInvalid</c> collection
        /// </summary>
        public WmiClassSet<MsftNetTransactInvalid> MsftNetTransactInvalid { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_NetTransactTimeout</c> collection
        /// </summary>
        public WmiClassSet<MsftNetTransactTimeout> MsftNetTransactTimeout { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_Providers</c> collection
        /// </summary>
        public WmiClassSet<MsftProviders> MsftProviders { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_SCMEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftScmEvent> MsftScmEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_SCMEventLogEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftScmEventLogEvent> MsftScmEventLogEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WMI_GenericNonCOMEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiGenericNonComEvent> MsftWmiGenericNonComEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiCancelNotificationSink</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiCancelNotificationSink> MsftWmiCancelNotificationSink { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiConsumerProviderEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiConsumerProviderEvent> MsftWmiConsumerProviderEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiConsumerProviderLoaded</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiConsumerProviderLoaded> MsftWmiConsumerProviderLoaded { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiConsumerProviderSinkLoaded</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiConsumerProviderSinkLoaded> MsftWmiConsumerProviderSinkLoaded { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiConsumerProviderSinkUnloaded</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiConsumerProviderSinkUnloaded> MsftWmiConsumerProviderSinkUnloaded { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiConsumerProviderUnloaded</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiConsumerProviderUnloaded> MsftWmiConsumerProviderUnloaded { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiError</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiError> MsftWmiError { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiEssEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiEssEvent> MsftWmiEssEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiFilterActivated</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiFilterActivated> MsftWmiFilterActivated { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiFilterDeactivated</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiFilterDeactivated> MsftWmiFilterDeactivated { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiFilterEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiFilterEvent> MsftWmiFilterEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_AccessCheck_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderAccessCheckPost> MsftWmiProviderAccessCheckPost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_AccessCheck_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderAccessCheckPre> MsftWmiProviderAccessCheckPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_CancelQuery_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderCancelQueryPost> MsftWmiProviderCancelQueryPost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_CancelQuery_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderCancelQueryPre> MsftWmiProviderCancelQueryPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_ComServerLoadOperationEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderComServerLoadOperationEvent> MsftWmiProviderComServerLoadOperationEvent
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_ComServerLoadOperationFailureEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderComServerLoadOperationFailureEvent>
            MsftWmiProviderComServerLoadOperationFailureEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_Counters</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderCounters> MsftWmiProviderCounters { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_CreateClassEnumAsyncEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderCreateClassEnumAsyncEventPost> MsftWmiProviderCreateClassEnumAsyncEventPost
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_CreateClassEnumAsyncEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderCreateClassEnumAsyncEventPre> MsftWmiProviderCreateClassEnumAsyncEventPre
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderCreateInstanceEnumAsyncEventPost>
            MsftWmiProviderCreateInstanceEnumAsyncEventPost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderCreateInstanceEnumAsyncEventPre>
            MsftWmiProviderCreateInstanceEnumAsyncEventPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_DeleteClassAsyncEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderDeleteClassAsyncEventPost> MsftWmiProviderDeleteClassAsyncEventPost
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_DeleteClassAsyncEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderDeleteClassAsyncEventPre> MsftWmiProviderDeleteClassAsyncEventPre
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_DeleteInstanceAsyncEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderDeleteInstanceAsyncEventPost> MsftWmiProviderDeleteInstanceAsyncEventPost
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_DeleteInstanceAsyncEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderDeleteInstanceAsyncEventPre> MsftWmiProviderDeleteInstanceAsyncEventPre
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_ExecMethodAsyncEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderExecMethodAsyncEventPost> MsftWmiProviderExecMethodAsyncEventPost
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_ExecMethodAsyncEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderExecMethodAsyncEventPre> MsftWmiProviderExecMethodAsyncEventPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_ExecQueryAsyncEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderExecQueryAsyncEventPost> MsftWmiProviderExecQueryAsyncEventPost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_ExecQueryAsyncEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderExecQueryAsyncEventPre> MsftWmiProviderExecQueryAsyncEventPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_GetObjectAsyncEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderGetObjectAsyncEventPost> MsftWmiProviderGetObjectAsyncEventPost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_GetObjectAsyncEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderGetObjectAsyncEventPre> MsftWmiProviderGetObjectAsyncEventPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_InitializationOperationEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderInitializationOperationEvent> MsftWmiProviderInitializationOperationEvent
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_InitializationOperationFailureEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderInitializationOperationFailureEvent>
            MsftWmiProviderInitializationOperationFailureEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_LoadOperationEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderLoadOperationEvent> MsftWmiProviderLoadOperationEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_LoadOperationFailureEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderLoadOperationFailureEvent> MsftWmiProviderLoadOperationFailureEvent
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_NewQuery_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderNewQueryPost> MsftWmiProviderNewQueryPost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_NewQuery_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderNewQueryPre> MsftWmiProviderNewQueryPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_OperationEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderOperationEvent> MsftWmiProviderOperationEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_OperationEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderOperationEventPost> MsftWmiProviderOperationEventPost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_OperationEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderOperationEventPre> MsftWmiProviderOperationEventPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_ProvideEvents_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderProvideEventsPost> MsftWmiProviderProvideEventsPost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_ProvideEvents_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderProvideEventsPre> MsftWmiProviderProvideEventsPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_PutClassAsyncEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderPutClassAsyncEventPost> MsftWmiProviderPutClassAsyncEventPost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_PutClassAsyncEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderPutClassAsyncEventPre> MsftWmiProviderPutClassAsyncEventPre { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_PutInstanceAsyncEvent_Post</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderPutInstanceAsyncEventPost> MsftWmiProviderPutInstanceAsyncEventPost
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_PutInstanceAsyncEvent_Pre</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderPutInstanceAsyncEventPre> MsftWmiProviderPutInstanceAsyncEventPre
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Msft_WmiProvider_UnLoadOperationEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderUnLoadOperationEvent> MsftWmiProviderUnLoadOperationEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiProviderEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiProviderEvent> MsftWmiProviderEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiRegisterNotificationSink</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiRegisterNotificationSink> MsftWmiRegisterNotificationSink { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiSelfEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiSelfEvent> MsftWmiSelfEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiThreadPoolEvent</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiThreadPoolEvent> MsftWmiThreadPoolEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiThreadPoolThreadCreated</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiThreadPoolThreadCreated> MsftWmiThreadPoolThreadCreated { get; set; }

        /// <summary>
        /// Representation of WMI class <c>MSFT_WmiThreadPoolThreadDeleted</c> collection
        /// </summary>
        public WmiClassSet<MsftWmiThreadPoolThreadDeleted> MsftWmiThreadPoolThreadDeleted { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_1394Controller</c> collection
        /// </summary>
        public WmiClassSet<Win321394Controller> Win321394Controller { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_1394ControllerDevice</c> collection
        /// </summary>
        public WmiClassSet<Win321394ControllerDevice> Win321394ControllerDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Account</c> collection
        /// </summary>
        public WmiClassSet<Win32Account> Win32Account { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_AccountSID</c> collection
        /// </summary>
        public WmiClassSet<Win32AccountSid> Win32AccountSid { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ACE</c> collection
        /// </summary>
        public WmiClassSet<Win32Ace> Win32Ace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ActionCheck</c> collection
        /// </summary>
        public WmiClassSet<Win32ActionCheck> Win32ActionCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ActiveRoute</c> collection
        /// </summary>
        public WmiClassSet<Win32ActiveRoute> Win32ActiveRoute { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_AllocatedResource</c> collection
        /// </summary>
        public WmiClassSet<Win32AllocatedResource> Win32AllocatedResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ApplicationCommandLine</c> collection
        /// </summary>
        public WmiClassSet<Win32ApplicationCommandLine> Win32ApplicationCommandLine { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ApplicationService</c> collection
        /// </summary>
        public WmiClassSet<Win32ApplicationService> Win32ApplicationService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_AssociatedProcessorMemory</c> collection
        /// </summary>
        public WmiClassSet<Win32AssociatedProcessorMemory> Win32AssociatedProcessorMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_AutochkSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32AutochkSetting> Win32AutochkSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_BaseBoard</c> collection
        /// </summary>
        public WmiClassSet<Win32BaseBoard> Win32BaseBoard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_BaseService</c> collection
        /// </summary>
        public WmiClassSet<Win32BaseService> Win32BaseService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Battery</c> collection
        /// </summary>
        public WmiClassSet<Win32Battery> Win32Battery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Binary</c> collection
        /// </summary>
        public WmiClassSet<Win32Binary> Win32Binary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_BindImageAction</c> collection
        /// </summary>
        public WmiClassSet<Win32BindImageAction> Win32BindImageAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_BIOS</c> collection
        /// </summary>
        public WmiClassSet<Win32Bios> Win32Bios { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_BitLockerEncryptionDetails</c> collection
        /// </summary>
        public WmiClassSet<Win32BitLockerEncryptionDetails> Win32BitLockerEncryptionDetails { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_BootConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32BootConfiguration> Win32BootConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Bus</c> collection
        /// </summary>
        public WmiClassSet<Win32Bus> Win32Bus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CacheMemory</c> collection
        /// </summary>
        public WmiClassSet<Win32CacheMemory> Win32CacheMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CDROMDrive</c> collection
        /// </summary>
        public WmiClassSet<Win32CdromDrive> Win32CdromDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CheckCheck</c> collection
        /// </summary>
        public WmiClassSet<Win32CheckCheck> Win32CheckCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CIMLogicalDeviceCIMDataFile</c> collection
        /// </summary>
        public WmiClassSet<Win32CimLogicalDeviceCimDataFile> Win32CimLogicalDeviceCimDataFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ClassicCOMApplicationClasses</c> collection
        /// </summary>
        public WmiClassSet<Win32ClassicComApplicationClasses> Win32ClassicComApplicationClasses { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ClassicCOMClass</c> collection
        /// </summary>
        public WmiClassSet<Win32ClassicComClass> Win32ClassicComClass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ClassicCOMClassSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32ClassicComClassSetting> Win32ClassicComClassSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ClassicCOMClassSettings</c> collection
        /// </summary>
        public WmiClassSet<Win32ClassicComClassSettings> Win32ClassicComClassSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ClassInfoAction</c> collection
        /// </summary>
        public WmiClassSet<Win32ClassInfoAction> Win32ClassInfoAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ClientApplicationSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32ClientApplicationSetting> Win32ClientApplicationSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ClusterShare</c> collection
        /// </summary>
        public WmiClassSet<Win32ClusterShare> Win32ClusterShare { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CodecFile</c> collection
        /// </summary>
        public WmiClassSet<Win32CodecFile> Win32CodecFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CollectionStatistics</c> collection
        /// </summary>
        public WmiClassSet<Win32CollectionStatistics> Win32CollectionStatistics { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_COMApplication</c> collection
        /// </summary>
        public WmiClassSet<Win32ComApplication> Win32ComApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_COMApplicationClasses</c> collection
        /// </summary>
        public WmiClassSet<Win32ComApplicationClasses> Win32ComApplicationClasses { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_COMApplicationSettings</c> collection
        /// </summary>
        public WmiClassSet<Win32ComApplicationSettings> Win32ComApplicationSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_COMClass</c> collection
        /// </summary>
        public WmiClassSet<Win32ComClass> Win32ComClass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ComClassAutoEmulator</c> collection
        /// </summary>
        public WmiClassSet<Win32ComClassAutoEmulator> Win32ComClassAutoEmulator { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ComClassEmulator</c> collection
        /// </summary>
        public WmiClassSet<Win32ComClassEmulator> Win32ComClassEmulator { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CommandLineAccess</c> collection
        /// </summary>
        public WmiClassSet<Win32CommandLineAccess> Win32CommandLineAccess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ComponentCategory</c> collection
        /// </summary>
        public WmiClassSet<Win32ComponentCategory> Win32ComponentCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ComputerShutdownEvent</c> collection
        /// </summary>
        public WmiClassSet<Win32ComputerShutdownEvent> Win32ComputerShutdownEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ComputerSystem</c> collection
        /// </summary>
        public WmiClassSet<Win32ComputerSystem> Win32ComputerSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ComputerSystemEvent</c> collection
        /// </summary>
        public WmiClassSet<Win32ComputerSystemEvent> Win32ComputerSystemEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ComputerSystemProcessor</c> collection
        /// </summary>
        public WmiClassSet<Win32ComputerSystemProcessor> Win32ComputerSystemProcessor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ComputerSystemProduct</c> collection
        /// </summary>
        public WmiClassSet<Win32ComputerSystemProduct> Win32ComputerSystemProduct { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_COMSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32ComSetting> Win32ComSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Condition</c> collection
        /// </summary>
        public WmiClassSet<Win32Condition> Win32Condition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ConnectionShare</c> collection
        /// </summary>
        public WmiClassSet<Win32ConnectionShare> Win32ConnectionShare { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ControllerHasHub</c> collection
        /// </summary>
        public WmiClassSet<Win32ControllerHasHub> Win32ControllerHasHub { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CreateFolderAction</c> collection
        /// </summary>
        public WmiClassSet<Win32CreateFolderAction> Win32CreateFolderAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CurrentProbe</c> collection
        /// </summary>
        public WmiClassSet<Win32CurrentProbe> Win32CurrentProbe { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_CurrentTime</c> collection
        /// </summary>
        public WmiClassSet<Win32CurrentTime> Win32CurrentTime { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DCOMApplication</c> collection
        /// </summary>
        public WmiClassSet<Win32DcomApplication> Win32DcomApplication { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DCOMApplicationAccessAllowedSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32DcomApplicationAccessAllowedSetting> Win32DcomApplicationAccessAllowedSetting
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Win32_DCOMApplicationLaunchAllowedSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32DcomApplicationLaunchAllowedSetting> Win32DcomApplicationLaunchAllowedSetting
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Win32_DCOMApplicationSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32DcomApplicationSetting> Win32DcomApplicationSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DefragAnalysis</c> collection
        /// </summary>
        public WmiClassSet<Win32DefragAnalysis> Win32DefragAnalysis { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DependentService</c> collection
        /// </summary>
        public WmiClassSet<Win32DependentService> Win32DependentService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Desktop</c> collection
        /// </summary>
        public WmiClassSet<Win32Desktop> Win32Desktop { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DesktopMonitor</c> collection
        /// </summary>
        public WmiClassSet<Win32DesktopMonitor> Win32DesktopMonitor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DeviceBus</c> collection
        /// </summary>
        public WmiClassSet<Win32DeviceBus> Win32DeviceBus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DeviceChangeEvent</c> collection
        /// </summary>
        public WmiClassSet<Win32DeviceChangeEvent> Win32DeviceChangeEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DeviceMemoryAddress</c> collection
        /// </summary>
        public WmiClassSet<Win32DeviceMemoryAddress> Win32DeviceMemoryAddress { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DeviceSettings</c> collection
        /// </summary>
        public WmiClassSet<Win32DeviceSettings> Win32DeviceSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DfsNode</c> collection
        /// </summary>
        public WmiClassSet<Win32DfsNode> Win32DfsNode { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DfsNodeTarget</c> collection
        /// </summary>
        public WmiClassSet<Win32DfsNodeTarget> Win32DfsNodeTarget { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DfsTarget</c> collection
        /// </summary>
        public WmiClassSet<Win32DfsTarget> Win32DfsTarget { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Directory</c> collection
        /// </summary>
        public WmiClassSet<Win32Directory> Win32Directory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DirectorySpecification</c> collection
        /// </summary>
        public WmiClassSet<Win32DirectorySpecification> Win32DirectorySpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DiskDrive</c> collection
        /// </summary>
        public WmiClassSet<Win32DiskDrive> Win32DiskDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DiskDrivePhysicalMedia</c> collection
        /// </summary>
        public WmiClassSet<Win32DiskDrivePhysicalMedia> Win32DiskDrivePhysicalMedia { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DiskDriveToDiskPartition</c> collection
        /// </summary>
        public WmiClassSet<Win32DiskDriveToDiskPartition> Win32DiskDriveToDiskPartition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DiskPartition</c> collection
        /// </summary>
        public WmiClassSet<Win32DiskPartition> Win32DiskPartition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DiskQuota</c> collection
        /// </summary>
        public WmiClassSet<Win32DiskQuota> Win32DiskQuota { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DisplayConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32DisplayConfiguration> Win32DisplayConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DisplayControllerConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32DisplayControllerConfiguration> Win32DisplayControllerConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DMAChannel</c> collection
        /// </summary>
        public WmiClassSet<Win32DmaChannel> Win32DmaChannel { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DriverForDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32DriverForDevice> Win32DriverForDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_DuplicateFileAction</c> collection
        /// </summary>
        public WmiClassSet<Win32DuplicateFileAction> Win32DuplicateFileAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Environment</c> collection
        /// </summary>
        public WmiClassSet<Win32Environment> Win32Environment { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_EnvironmentSpecification</c> collection
        /// </summary>
        public WmiClassSet<Win32EnvironmentSpecification> Win32EnvironmentSpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ExtensionInfoAction</c> collection
        /// </summary>
        public WmiClassSet<Win32ExtensionInfoAction> Win32ExtensionInfoAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Fan</c> collection
        /// </summary>
        public WmiClassSet<Win32Fan> Win32Fan { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_FileSpecification</c> collection
        /// </summary>
        public WmiClassSet<Win32FileSpecification> Win32FileSpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_FolderRedirection</c> collection
        /// </summary>
        public WmiClassSet<Win32FolderRedirection> Win32FolderRedirection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_FolderRedirectionHealth</c> collection
        /// </summary>
        public WmiClassSet<Win32FolderRedirectionHealth> Win32FolderRedirectionHealth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_FolderRedirectionHealthConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32FolderRedirectionHealthConfiguration> Win32FolderRedirectionHealthConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Win32_FolderRedirectionUserConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32FolderRedirectionUserConfiguration> Win32FolderRedirectionUserConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Win32_FontInfoAction</c> collection
        /// </summary>
        public WmiClassSet<Win32FontInfoAction> Win32FontInfoAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Group</c> collection
        /// </summary>
        public WmiClassSet<Win32Group> Win32Group { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_GroupInDomain</c> collection
        /// </summary>
        public WmiClassSet<Win32GroupInDomain> Win32GroupInDomain { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_GroupUser</c> collection
        /// </summary>
        public WmiClassSet<Win32GroupUser> Win32GroupUser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_HeatPipe</c> collection
        /// </summary>
        public WmiClassSet<Win32HeatPipe> Win32HeatPipe { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_IDEController</c> collection
        /// </summary>
        public WmiClassSet<Win32IdeController> Win32IdeController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_IDEControllerDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32IdeControllerDevice> Win32IdeControllerDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ImplementedCategory</c> collection
        /// </summary>
        public WmiClassSet<Win32ImplementedCategory> Win32ImplementedCategory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_InfraredDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32InfraredDevice> Win32InfraredDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_IniFileSpecification</c> collection
        /// </summary>
        public WmiClassSet<Win32IniFileSpecification> Win32IniFileSpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_InstalledProgramFramework</c> collection
        /// </summary>
        public WmiClassSet<Win32InstalledProgramFramework> Win32InstalledProgramFramework { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_InstalledSoftwareElement</c> collection
        /// </summary>
        public WmiClassSet<Win32InstalledSoftwareElement> Win32InstalledSoftwareElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_InstalledStoreProgram</c> collection
        /// </summary>
        public WmiClassSet<Win32InstalledStoreProgram> Win32InstalledStoreProgram { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_InstalledWin32Program</c> collection
        /// </summary>
        public WmiClassSet<Win32InstalledWin32Program> Win32InstalledWin32Program { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_IP4PersistedRouteTable</c> collection
        /// </summary>
        public WmiClassSet<Win32Ip4PersistedRouteTable> Win32Ip4PersistedRouteTable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_IP4RouteTable</c> collection
        /// </summary>
        public WmiClassSet<Win32Ip4RouteTable> Win32Ip4RouteTable { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_IP4RouteTableEvent</c> collection
        /// </summary>
        public WmiClassSet<Win32Ip4RouteTableEvent> Win32Ip4RouteTableEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_IRQResource</c> collection
        /// </summary>
        public WmiClassSet<Win32IrqResource> Win32IrqResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_JobObjectStatus</c> collection
        /// </summary>
        public WmiClassSet<Win32JobObjectStatus> Win32JobObjectStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Keyboard</c> collection
        /// </summary>
        public WmiClassSet<Win32Keyboard> Win32Keyboard { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LaunchCondition</c> collection
        /// </summary>
        public WmiClassSet<Win32LaunchCondition> Win32LaunchCondition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LoadOrderGroup</c> collection
        /// </summary>
        public WmiClassSet<Win32LoadOrderGroup> Win32LoadOrderGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LoadOrderGroupServiceDependencies</c> collection
        /// </summary>
        public WmiClassSet<Win32LoadOrderGroupServiceDependencies> Win32LoadOrderGroupServiceDependencies { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LoadOrderGroupServiceMembers</c> collection
        /// </summary>
        public WmiClassSet<Win32LoadOrderGroupServiceMembers> Win32LoadOrderGroupServiceMembers { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LocalTime</c> collection
        /// </summary>
        public WmiClassSet<Win32LocalTime> Win32LocalTime { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LoggedOnUser</c> collection
        /// </summary>
        public WmiClassSet<Win32LoggedOnUser> Win32LoggedOnUser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalDisk</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalDisk> Win32LogicalDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalDiskRootDirectory</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalDiskRootDirectory> Win32LogicalDiskRootDirectory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalDiskToPartition</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalDiskToPartition> Win32LogicalDiskToPartition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalFileAccess</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalFileAccess> Win32LogicalFileAccess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalFileAuditing</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalFileAuditing> Win32LogicalFileAuditing { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalFileGroup</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalFileGroup> Win32LogicalFileGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalFileOwner</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalFileOwner> Win32LogicalFileOwner { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalFileSecuritySetting</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalFileSecuritySetting> Win32LogicalFileSecuritySetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalProgramGroup</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalProgramGroup> Win32LogicalProgramGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalProgramGroupDirectory</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalProgramGroupDirectory> Win32LogicalProgramGroupDirectory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalProgramGroupItem</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalProgramGroupItem> Win32LogicalProgramGroupItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalProgramGroupItemDataFile</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalProgramGroupItemDataFile> Win32LogicalProgramGroupItemDataFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalShareAccess</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalShareAccess> Win32LogicalShareAccess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalShareAuditing</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalShareAuditing> Win32LogicalShareAuditing { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogicalShareSecuritySetting</c> collection
        /// </summary>
        public WmiClassSet<Win32LogicalShareSecuritySetting> Win32LogicalShareSecuritySetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogonSession</c> collection
        /// </summary>
        public WmiClassSet<Win32LogonSession> Win32LogonSession { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LogonSessionMappedDisk</c> collection
        /// </summary>
        public WmiClassSet<Win32LogonSessionMappedDisk> Win32LogonSessionMappedDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LUID</c> collection
        /// </summary>
        public WmiClassSet<Win32Luid> Win32Luid { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_LUIDandAttributes</c> collection
        /// </summary>
        public WmiClassSet<Win32LuiDandAttributes> Win32LuiDandAttributes { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ManagedSystemElementResource</c> collection
        /// </summary>
        public WmiClassSet<Win32ManagedSystemElementResource> Win32ManagedSystemElementResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MappedLogicalDisk</c> collection
        /// </summary>
        public WmiClassSet<Win32MappedLogicalDisk> Win32MappedLogicalDisk { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MemoryArray</c> collection
        /// </summary>
        public WmiClassSet<Win32MemoryArray> Win32MemoryArray { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MemoryArrayLocation</c> collection
        /// </summary>
        public WmiClassSet<Win32MemoryArrayLocation> Win32MemoryArrayLocation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MemoryDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32MemoryDevice> Win32MemoryDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MemoryDeviceArray</c> collection
        /// </summary>
        public WmiClassSet<Win32MemoryDeviceArray> Win32MemoryDeviceArray { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MemoryDeviceLocation</c> collection
        /// </summary>
        public WmiClassSet<Win32MemoryDeviceLocation> Win32MemoryDeviceLocation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MethodParameterClass</c> collection
        /// </summary>
        public WmiClassSet<Win32MethodParameterClass> Win32MethodParameterClass { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MIMEInfoAction</c> collection
        /// </summary>
        public WmiClassSet<Win32MimeInfoAction> Win32MimeInfoAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ModuleLoadTrace</c> collection
        /// </summary>
        public WmiClassSet<Win32ModuleLoadTrace> Win32ModuleLoadTrace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ModuleTrace</c> collection
        /// </summary>
        public WmiClassSet<Win32ModuleTrace> Win32ModuleTrace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MotherboardDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32MotherboardDevice> Win32MotherboardDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MountPoint</c> collection
        /// </summary>
        public WmiClassSet<Win32MountPoint> Win32MountPoint { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MoveFileAction</c> collection
        /// </summary>
        public WmiClassSet<Win32MoveFileAction> Win32MoveFileAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_MSIResource</c> collection
        /// </summary>
        public WmiClassSet<Win32MsiResource> Win32MsiResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NamedJobObject</c> collection
        /// </summary>
        public WmiClassSet<Win32NamedJobObject> Win32NamedJobObject { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NamedJobObjectActgInfo</c> collection
        /// </summary>
        public WmiClassSet<Win32NamedJobObjectActgInfo> Win32NamedJobObjectActgInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NamedJobObjectLimit</c> collection
        /// </summary>
        public WmiClassSet<Win32NamedJobObjectLimit> Win32NamedJobObjectLimit { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NamedJobObjectLimitSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32NamedJobObjectLimitSetting> Win32NamedJobObjectLimitSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NamedJobObjectProcess</c> collection
        /// </summary>
        public WmiClassSet<Win32NamedJobObjectProcess> Win32NamedJobObjectProcess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NamedJobObjectSecLimit</c> collection
        /// </summary>
        public WmiClassSet<Win32NamedJobObjectSecLimit> Win32NamedJobObjectSecLimit { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NamedJobObjectSecLimitSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32NamedJobObjectSecLimitSetting> Win32NamedJobObjectSecLimitSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NamedJobObjectStatistics</c> collection
        /// </summary>
        public WmiClassSet<Win32NamedJobObjectStatistics> Win32NamedJobObjectStatistics { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NetworkAdapter</c> collection
        /// </summary>
        public WmiClassSet<Win32NetworkAdapter> Win32NetworkAdapter { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NetworkAdapterConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32NetworkAdapterConfiguration> Win32NetworkAdapterConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NetworkAdapterSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32NetworkAdapterSetting> Win32NetworkAdapterSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NetworkClient</c> collection
        /// </summary>
        public WmiClassSet<Win32NetworkClient> Win32NetworkClient { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NetworkConnection</c> collection
        /// </summary>
        public WmiClassSet<Win32NetworkConnection> Win32NetworkConnection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NetworkLoginProfile</c> collection
        /// </summary>
        public WmiClassSet<Win32NetworkLoginProfile> Win32NetworkLoginProfile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NetworkProtocol</c> collection
        /// </summary>
        public WmiClassSet<Win32NetworkProtocol> Win32NetworkProtocol { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NTDomain</c> collection
        /// </summary>
        public WmiClassSet<Win32NtDomain> Win32NtDomain { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NTEventlogFile</c> collection
        /// </summary>
        public WmiClassSet<Win32NtEventlogFile> Win32NtEventlogFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NTLogEvent</c> collection
        /// </summary>
        public WmiClassSet<Win32NtLogEvent> Win32NtLogEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NTLogEventComputer</c> collection
        /// </summary>
        public WmiClassSet<Win32NtLogEventComputer> Win32NtLogEventComputer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NTLogEventLog</c> collection
        /// </summary>
        public WmiClassSet<Win32NtLogEventLog> Win32NtLogEventLog { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_NTLogEventUser</c> collection
        /// </summary>
        public WmiClassSet<Win32NtLogEventUser> Win32NtLogEventUser { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ODBCAttribute</c> collection
        /// </summary>
        public WmiClassSet<Win32OdbcAttribute> Win32OdbcAttribute { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ODBCDataSourceAttribute</c> collection
        /// </summary>
        public WmiClassSet<Win32OdbcDataSourceAttribute> Win32OdbcDataSourceAttribute { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ODBCDataSourceSpecification</c> collection
        /// </summary>
        public WmiClassSet<Win32OdbcDataSourceSpecification> Win32OdbcDataSourceSpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ODBCDriverAttribute</c> collection
        /// </summary>
        public WmiClassSet<Win32OdbcDriverAttribute> Win32OdbcDriverAttribute { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ODBCDriverSoftwareElement</c> collection
        /// </summary>
        public WmiClassSet<Win32OdbcDriverSoftwareElement> Win32OdbcDriverSoftwareElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ODBCDriverSpecification</c> collection
        /// </summary>
        public WmiClassSet<Win32OdbcDriverSpecification> Win32OdbcDriverSpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ODBCSourceAttribute</c> collection
        /// </summary>
        public WmiClassSet<Win32OdbcSourceAttribute> Win32OdbcSourceAttribute { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ODBCTranslatorSpecification</c> collection
        /// </summary>
        public WmiClassSet<Win32OdbcTranslatorSpecification> Win32OdbcTranslatorSpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesAssociatedItems</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesAssociatedItems> Win32OfflineFilesAssociatedItems { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesBackgroundSync</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesBackgroundSync> Win32OfflineFilesBackgroundSync { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesCache</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesCache> Win32OfflineFilesCache { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesChangeInfo</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesChangeInfo> Win32OfflineFilesChangeInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesConnectionInfo</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesConnectionInfo> Win32OfflineFilesConnectionInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesDirtyInfo</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesDirtyInfo> Win32OfflineFilesDirtyInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesDiskSpaceLimit</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesDiskSpaceLimit> Win32OfflineFilesDiskSpaceLimit { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesFileSysInfo</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesFileSysInfo> Win32OfflineFilesFileSysInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesHealth</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesHealth> Win32OfflineFilesHealth { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesItem</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesItem> Win32OfflineFilesItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesMachineConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesMachineConfiguration> Win32OfflineFilesMachineConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesPinInfo</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesPinInfo> Win32OfflineFilesPinInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesSuspendInfo</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesSuspendInfo> Win32OfflineFilesSuspendInfo { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OfflineFilesUserConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32OfflineFilesUserConfiguration> Win32OfflineFilesUserConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OnBoardDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32OnBoardDevice> Win32OnBoardDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OperatingSystem</c> collection
        /// </summary>
        public WmiClassSet<Win32OperatingSystem> Win32OperatingSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OperatingSystemAutochkSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32OperatingSystemAutochkSetting> Win32OperatingSystemAutochkSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OperatingSystemQFE</c> collection
        /// </summary>
        public WmiClassSet<Win32OperatingSystemQfe> Win32OperatingSystemQfe { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OptionalFeature</c> collection
        /// </summary>
        public WmiClassSet<Win32OptionalFeature> Win32OptionalFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_OSRecoveryConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32OsRecoveryConfiguration> Win32OsRecoveryConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PageFile</c> collection
        /// </summary>
        public WmiClassSet<Win32PageFile> Win32PageFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PageFileElementSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32PageFileElementSetting> Win32PageFileElementSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PageFileSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32PageFileSetting> Win32PageFileSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PageFileUsage</c> collection
        /// </summary>
        public WmiClassSet<Win32PageFileUsage> Win32PageFileUsage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ParallelPort</c> collection
        /// </summary>
        public WmiClassSet<Win32ParallelPort> Win32ParallelPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Patch</c> collection
        /// </summary>
        public WmiClassSet<Win32Patch> Win32Patch { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PatchFile</c> collection
        /// </summary>
        public WmiClassSet<Win32PatchFile> Win32PatchFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PatchPackage</c> collection
        /// </summary>
        public WmiClassSet<Win32PatchPackage> Win32PatchPackage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PCMCIAController</c> collection
        /// </summary>
        public WmiClassSet<Win32PcmciaController> Win32PcmciaController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Perf</c> collection
        /// </summary>
        public WmiClassSet<Win32Perf> Win32Perf { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PhysicalMedia</c> collection
        /// </summary>
        public WmiClassSet<Win32PhysicalMedia> Win32PhysicalMedia { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PhysicalMemory</c> collection
        /// </summary>
        public WmiClassSet<Win32PhysicalMemory> Win32PhysicalMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PhysicalMemoryArray</c> collection
        /// </summary>
        public WmiClassSet<Win32PhysicalMemoryArray> Win32PhysicalMemoryArray { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PhysicalMemoryLocation</c> collection
        /// </summary>
        public WmiClassSet<Win32PhysicalMemoryLocation> Win32PhysicalMemoryLocation { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PingStatus</c> collection
        /// </summary>
        public WmiClassSet<Win32PingStatus> Win32PingStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PNPAllocatedResource</c> collection
        /// </summary>
        public WmiClassSet<Win32PnpAllocatedResource> Win32PnpAllocatedResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevice> Win32PnPDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDeviceProperty</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDeviceProperty> Win32PnPDeviceProperty { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyBinary</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyBinary> Win32PnPDevicePropertyBinary { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyBoolean</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyBoolean> Win32PnPDevicePropertyBoolean { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyBooleanArray</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyBooleanArray> Win32PnPDevicePropertyBooleanArray { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyDateTime</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyDateTime> Win32PnPDevicePropertyDateTime { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyReal32</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyReal32> Win32PnPDevicePropertyReal32 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyReal32Array</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyReal32Array> Win32PnPDevicePropertyReal32Array { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyReal64</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyReal64> Win32PnPDevicePropertyReal64 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyReal64Array</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyReal64Array> Win32PnPDevicePropertyReal64Array { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertySecurityDescriptor</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertySecurityDescriptor> Win32PnPDevicePropertySecurityDescriptor
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertySecurityDescriptorArray</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertySecurityDescriptorArray> Win32PnPDevicePropertySecurityDescriptorArray
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertySint16</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertySint16> Win32PnPDevicePropertySint16 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertySint16Array</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertySint16Array> Win32PnPDevicePropertySint16Array { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertySint32</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertySint32> Win32PnPDevicePropertySint32 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertySint32Array</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertySint32Array> Win32PnPDevicePropertySint32Array { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertySint64</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertySint64> Win32PnPDevicePropertySint64 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertySint8</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertySint8> Win32PnPDevicePropertySint8 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertySint8Array</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertySint8Array> Win32PnPDevicePropertySint8Array { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyString</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyString> Win32PnPDevicePropertyString { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyStringArray</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyStringArray> Win32PnPDevicePropertyStringArray { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyUint16</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyUint16> Win32PnPDevicePropertyUint16 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyUint16Array</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyUint16Array> Win32PnPDevicePropertyUint16Array { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyUint32</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyUint32> Win32PnPDevicePropertyUint32 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyUint32Array</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyUint32Array> Win32PnPDevicePropertyUint32Array { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyUint64</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyUint64> Win32PnPDevicePropertyUint64 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPDevicePropertyUint8</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPDevicePropertyUint8> Win32PnPDevicePropertyUint8 { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPEntity</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPEntity> Win32PnPEntity { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPSignedDriver</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPSignedDriver> Win32PnPSignedDriver { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PnPSignedDriverCIMDataFile</c> collection
        /// </summary>
        public WmiClassSet<Win32PnPSignedDriverCimDataFile> Win32PnPSignedDriverCimDataFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PointingDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32PointingDevice> Win32PointingDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PortableBattery</c> collection
        /// </summary>
        public WmiClassSet<Win32PortableBattery> Win32PortableBattery { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PortConnector</c> collection
        /// </summary>
        public WmiClassSet<Win32PortConnector> Win32PortConnector { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PortResource</c> collection
        /// </summary>
        public WmiClassSet<Win32PortResource> Win32PortResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_POTSModem</c> collection
        /// </summary>
        public WmiClassSet<Win32PotsModem> Win32PotsModem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_POTSModemToSerialPort</c> collection
        /// </summary>
        public WmiClassSet<Win32PotsModemToSerialPort> Win32PotsModemToSerialPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PowerManagementEvent</c> collection
        /// </summary>
        public WmiClassSet<Win32PowerManagementEvent> Win32PowerManagementEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Printer</c> collection
        /// </summary>
        public WmiClassSet<Win32Printer> Win32Printer { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PrinterConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32PrinterConfiguration> Win32PrinterConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PrinterController</c> collection
        /// </summary>
        public WmiClassSet<Win32PrinterController> Win32PrinterController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PrinterDriver</c> collection
        /// </summary>
        public WmiClassSet<Win32PrinterDriver> Win32PrinterDriver { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PrinterDriverDll</c> collection
        /// </summary>
        public WmiClassSet<Win32PrinterDriverDll> Win32PrinterDriverDll { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PrinterSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32PrinterSetting> Win32PrinterSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PrinterShare</c> collection
        /// </summary>
        public WmiClassSet<Win32PrinterShare> Win32PrinterShare { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PrintJob</c> collection
        /// </summary>
        public WmiClassSet<Win32PrintJob> Win32PrintJob { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PrivilegesStatus</c> collection
        /// </summary>
        public WmiClassSet<Win32PrivilegesStatus> Win32PrivilegesStatus { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Process</c> collection
        /// </summary>
        public WmiClassSet<Win32Process> Win32Process { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Processor</c> collection
        /// </summary>
        public WmiClassSet<Win32Processor> Win32Processor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProcessStartTrace</c> collection
        /// </summary>
        public WmiClassSet<Win32ProcessStartTrace> Win32ProcessStartTrace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProcessStartup</c> collection
        /// </summary>
        public WmiClassSet<Win32ProcessStartup> Win32ProcessStartup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProcessStopTrace</c> collection
        /// </summary>
        public WmiClassSet<Win32ProcessStopTrace> Win32ProcessStopTrace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProcessTrace</c> collection
        /// </summary>
        public WmiClassSet<Win32ProcessTrace> Win32ProcessTrace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Product</c> collection
        /// </summary>
        public WmiClassSet<Win32Product> Win32Product { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProductCheck</c> collection
        /// </summary>
        public WmiClassSet<Win32ProductCheck> Win32ProductCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProductResource</c> collection
        /// </summary>
        public WmiClassSet<Win32ProductResource> Win32ProductResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProductSoftwareFeatures</c> collection
        /// </summary>
        public WmiClassSet<Win32ProductSoftwareFeatures> Win32ProductSoftwareFeatures { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProgIDSpecification</c> collection
        /// </summary>
        public WmiClassSet<Win32ProgIdSpecification> Win32ProgIdSpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProgramGroupContents</c> collection
        /// </summary>
        public WmiClassSet<Win32ProgramGroupContents> Win32ProgramGroupContents { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProgramGroupOrItem</c> collection
        /// </summary>
        public WmiClassSet<Win32ProgramGroupOrItem> Win32ProgramGroupOrItem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Property</c> collection
        /// </summary>
        public WmiClassSet<Win32Property> Win32Property { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ProtocolBinding</c> collection
        /// </summary>
        public WmiClassSet<Win32ProtocolBinding> Win32ProtocolBinding { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_PublishComponentAction</c> collection
        /// </summary>
        public WmiClassSet<Win32PublishComponentAction> Win32PublishComponentAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_QuickFixEngineering</c> collection
        /// </summary>
        public WmiClassSet<Win32QuickFixEngineering> Win32QuickFixEngineering { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_QuotaSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32QuotaSetting> Win32QuotaSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Refrigeration</c> collection
        /// </summary>
        public WmiClassSet<Win32Refrigeration> Win32Refrigeration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Registry</c> collection
        /// </summary>
        public WmiClassSet<Win32Registry> Win32Registry { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_RegistryAction</c> collection
        /// </summary>
        public WmiClassSet<Win32RegistryAction> Win32RegistryAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Reliability</c> collection
        /// </summary>
        public WmiClassSet<Win32Reliability> Win32Reliability { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ReliabilityRecords</c> collection
        /// </summary>
        public WmiClassSet<Win32ReliabilityRecords> Win32ReliabilityRecords { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ReliabilityStabilityMetrics</c> collection
        /// </summary>
        public WmiClassSet<Win32ReliabilityStabilityMetrics> Win32ReliabilityStabilityMetrics { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_RemoveFileAction</c> collection
        /// </summary>
        public WmiClassSet<Win32RemoveFileAction> Win32RemoveFileAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_RemoveIniAction</c> collection
        /// </summary>
        public WmiClassSet<Win32RemoveIniAction> Win32RemoveIniAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ReserveCost</c> collection
        /// </summary>
        public WmiClassSet<Win32ReserveCost> Win32ReserveCost { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_RoamingProfileBackgroundUploadParams</c> collection
        /// </summary>
        public WmiClassSet<Win32RoamingProfileBackgroundUploadParams> Win32RoamingProfileBackgroundUploadParams
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Win32_RoamingProfileMachineConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32RoamingProfileMachineConfiguration> Win32RoamingProfileMachineConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// Representation of WMI class <c>Win32_RoamingProfileSlowLinkParams</c> collection
        /// </summary>
        public WmiClassSet<Win32RoamingProfileSlowLinkParams> Win32RoamingProfileSlowLinkParams { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_RoamingProfileUserConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32RoamingProfileUserConfiguration> Win32RoamingProfileUserConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_RoamingUserHealthConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32RoamingUserHealthConfiguration> Win32RoamingUserHealthConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ScheduledJob</c> collection
        /// </summary>
        public WmiClassSet<Win32ScheduledJob> Win32ScheduledJob { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SCSIController</c> collection
        /// </summary>
        public WmiClassSet<Win32ScsiController> Win32ScsiController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SCSIControllerDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32ScsiControllerDevice> Win32ScsiControllerDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecurityDescriptor</c> collection
        /// </summary>
        public WmiClassSet<Win32SecurityDescriptor> Win32SecurityDescriptor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecurityDescriptorHelper</c> collection
        /// </summary>
        public WmiClassSet<Win32SecurityDescriptorHelper> Win32SecurityDescriptorHelper { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecuritySetting</c> collection
        /// </summary>
        public WmiClassSet<Win32SecuritySetting> Win32SecuritySetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecuritySettingAccess</c> collection
        /// </summary>
        public WmiClassSet<Win32SecuritySettingAccess> Win32SecuritySettingAccess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecuritySettingAuditing</c> collection
        /// </summary>
        public WmiClassSet<Win32SecuritySettingAuditing> Win32SecuritySettingAuditing { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecuritySettingGroup</c> collection
        /// </summary>
        public WmiClassSet<Win32SecuritySettingGroup> Win32SecuritySettingGroup { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecuritySettingOfLogicalFile</c> collection
        /// </summary>
        public WmiClassSet<Win32SecuritySettingOfLogicalFile> Win32SecuritySettingOfLogicalFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecuritySettingOfLogicalShare</c> collection
        /// </summary>
        public WmiClassSet<Win32SecuritySettingOfLogicalShare> Win32SecuritySettingOfLogicalShare { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecuritySettingOfObject</c> collection
        /// </summary>
        public WmiClassSet<Win32SecuritySettingOfObject> Win32SecuritySettingOfObject { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SecuritySettingOwner</c> collection
        /// </summary>
        public WmiClassSet<Win32SecuritySettingOwner> Win32SecuritySettingOwner { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SelfRegModuleAction</c> collection
        /// </summary>
        public WmiClassSet<Win32SelfRegModuleAction> Win32SelfRegModuleAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SerialPort</c> collection
        /// </summary>
        public WmiClassSet<Win32SerialPort> Win32SerialPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SerialPortConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32SerialPortConfiguration> Win32SerialPortConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SerialPortSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32SerialPortSetting> Win32SerialPortSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ServerConnection</c> collection
        /// </summary>
        public WmiClassSet<Win32ServerConnection> Win32ServerConnection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ServerSession</c> collection
        /// </summary>
        public WmiClassSet<Win32ServerSession> Win32ServerSession { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Service</c> collection
        /// </summary>
        public WmiClassSet<Win32Service> Win32Service { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ServiceControl</c> collection
        /// </summary>
        public WmiClassSet<Win32ServiceControl> Win32ServiceControl { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ServiceSpecification</c> collection
        /// </summary>
        public WmiClassSet<Win32ServiceSpecification> Win32ServiceSpecification { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ServiceSpecificationService</c> collection
        /// </summary>
        public WmiClassSet<Win32ServiceSpecificationService> Win32ServiceSpecificationService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Session</c> collection
        /// </summary>
        public WmiClassSet<Win32Session> Win32Session { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SessionConnection</c> collection
        /// </summary>
        public WmiClassSet<Win32SessionConnection> Win32SessionConnection { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SessionProcess</c> collection
        /// </summary>
        public WmiClassSet<Win32SessionProcess> Win32SessionProcess { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SessionResource</c> collection
        /// </summary>
        public WmiClassSet<Win32SessionResource> Win32SessionResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SettingCheck</c> collection
        /// </summary>
        public WmiClassSet<Win32SettingCheck> Win32SettingCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShadowBy</c> collection
        /// </summary>
        public WmiClassSet<Win32ShadowBy> Win32ShadowBy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShadowContext</c> collection
        /// </summary>
        public WmiClassSet<Win32ShadowContext> Win32ShadowContext { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShadowCopy</c> collection
        /// </summary>
        public WmiClassSet<Win32ShadowCopy> Win32ShadowCopy { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShadowDiffVolumeSupport</c> collection
        /// </summary>
        public WmiClassSet<Win32ShadowDiffVolumeSupport> Win32ShadowDiffVolumeSupport { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShadowFor</c> collection
        /// </summary>
        public WmiClassSet<Win32ShadowFor> Win32ShadowFor { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShadowOn</c> collection
        /// </summary>
        public WmiClassSet<Win32ShadowOn> Win32ShadowOn { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShadowProvider</c> collection
        /// </summary>
        public WmiClassSet<Win32ShadowProvider> Win32ShadowProvider { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShadowStorage</c> collection
        /// </summary>
        public WmiClassSet<Win32ShadowStorage> Win32ShadowStorage { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShadowVolumeSupport</c> collection
        /// </summary>
        public WmiClassSet<Win32ShadowVolumeSupport> Win32ShadowVolumeSupport { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Share</c> collection
        /// </summary>
        public WmiClassSet<Win32Share> Win32Share { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShareToDirectory</c> collection
        /// </summary>
        public WmiClassSet<Win32ShareToDirectory> Win32ShareToDirectory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShortcutAction</c> collection
        /// </summary>
        public WmiClassSet<Win32ShortcutAction> Win32ShortcutAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShortcutFile</c> collection
        /// </summary>
        public WmiClassSet<Win32ShortcutFile> Win32ShortcutFile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ShortcutSAP</c> collection
        /// </summary>
        public WmiClassSet<Win32ShortcutSap> Win32ShortcutSap { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SID</c> collection
        /// </summary>
        public WmiClassSet<Win32Sid> Win32Sid { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SIDandAttributes</c> collection
        /// </summary>
        public WmiClassSet<Win32SiDandAttributes> Win32SiDandAttributes { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SMBIOSMemory</c> collection
        /// </summary>
        public WmiClassSet<Win32SmbiosMemory> Win32SmbiosMemory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareElement</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareElement> Win32SoftwareElement { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareElementAction</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareElementAction> Win32SoftwareElementAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareElementCheck</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareElementCheck> Win32SoftwareElementCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareElementCondition</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareElementCondition> Win32SoftwareElementCondition { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareElementResource</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareElementResource> Win32SoftwareElementResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareFeature</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareFeature> Win32SoftwareFeature { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareFeatureAction</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareFeatureAction> Win32SoftwareFeatureAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareFeatureCheck</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareFeatureCheck> Win32SoftwareFeatureCheck { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareFeatureParent</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareFeatureParent> Win32SoftwareFeatureParent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoftwareFeatureSoftwareElements</c> collection
        /// </summary>
        public WmiClassSet<Win32SoftwareFeatureSoftwareElements> Win32SoftwareFeatureSoftwareElements { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SoundDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32SoundDevice> Win32SoundDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_StartupCommand</c> collection
        /// </summary>
        public WmiClassSet<Win32StartupCommand> Win32StartupCommand { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SubDirectory</c> collection
        /// </summary>
        public WmiClassSet<Win32SubDirectory> Win32SubDirectory { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SubSession</c> collection
        /// </summary>
        public WmiClassSet<Win32SubSession> Win32SubSession { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemAccount</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemAccount> Win32SystemAccount { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemBIOS</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemBios> Win32SystemBios { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemBootConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemBootConfiguration> Win32SystemBootConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemConfigurationChangeEvent</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemConfigurationChangeEvent> Win32SystemConfigurationChangeEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemDesktop</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemDesktop> Win32SystemDesktop { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemDevices</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemDevices> Win32SystemDevices { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemDriver</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemDriver> Win32SystemDriver { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemDriverPNPEntity</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemDriverPnpEntity> Win32SystemDriverPnpEntity { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemEnclosure</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemEnclosure> Win32SystemEnclosure { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemLoadOrderGroups</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemLoadOrderGroups> Win32SystemLoadOrderGroups { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemMemoryResource</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemMemoryResource> Win32SystemMemoryResource { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemNetworkConnections</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemNetworkConnections> Win32SystemNetworkConnections { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemOperatingSystem</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemOperatingSystem> Win32SystemOperatingSystem { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemPartitions</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemPartitions> Win32SystemPartitions { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemProcesses</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemProcesses> Win32SystemProcesses { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemProgramGroups</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemProgramGroups> Win32SystemProgramGroups { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemResources</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemResources> Win32SystemResources { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemServices</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemServices> Win32SystemServices { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemSetting> Win32SystemSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemSlot</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemSlot> Win32SystemSlot { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemSystemDriver</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemSystemDriver> Win32SystemSystemDriver { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemTimeZone</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemTimeZone> Win32SystemTimeZone { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemTrace</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemTrace> Win32SystemTrace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_SystemUsers</c> collection
        /// </summary>
        public WmiClassSet<Win32SystemUsers> Win32SystemUsers { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_TapeDrive</c> collection
        /// </summary>
        public WmiClassSet<Win32TapeDrive> Win32TapeDrive { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_TCPIPPrinterPort</c> collection
        /// </summary>
        public WmiClassSet<Win32TcpipPrinterPort> Win32TcpipPrinterPort { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_TemperatureProbe</c> collection
        /// </summary>
        public WmiClassSet<Win32TemperatureProbe> Win32TemperatureProbe { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_TerminalService</c> collection
        /// </summary>
        public WmiClassSet<Win32TerminalService> Win32TerminalService { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Thread</c> collection
        /// </summary>
        public WmiClassSet<Win32Thread> Win32Thread { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ThreadStartTrace</c> collection
        /// </summary>
        public WmiClassSet<Win32ThreadStartTrace> Win32ThreadStartTrace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ThreadStopTrace</c> collection
        /// </summary>
        public WmiClassSet<Win32ThreadStopTrace> Win32ThreadStopTrace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_ThreadTrace</c> collection
        /// </summary>
        public WmiClassSet<Win32ThreadTrace> Win32ThreadTrace { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_TimeZone</c> collection
        /// </summary>
        public WmiClassSet<Win32TimeZone> Win32TimeZone { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_TokenGroups</c> collection
        /// </summary>
        public WmiClassSet<Win32TokenGroups> Win32TokenGroups { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_TokenPrivileges</c> collection
        /// </summary>
        public WmiClassSet<Win32TokenPrivileges> Win32TokenPrivileges { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Trustee</c> collection
        /// </summary>
        public WmiClassSet<Win32Trustee> Win32Trustee { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_TypeLibraryAction</c> collection
        /// </summary>
        public WmiClassSet<Win32TypeLibraryAction> Win32TypeLibraryAction { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_USBController</c> collection
        /// </summary>
        public WmiClassSet<Win32UsbController> Win32UsbController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_USBControllerDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32UsbControllerDevice> Win32UsbControllerDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_USBDevice</c> collection
        /// </summary>
        public WmiClassSet<Win32UsbDevice> Win32UsbDevice { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_USBHub</c> collection
        /// </summary>
        public WmiClassSet<Win32UsbHub> Win32UsbHub { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_UserAccount</c> collection
        /// </summary>
        public WmiClassSet<Win32UserAccount> Win32UserAccount { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_UserDesktop</c> collection
        /// </summary>
        public WmiClassSet<Win32UserDesktop> Win32UserDesktop { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_UserInDomain</c> collection
        /// </summary>
        public WmiClassSet<Win32UserInDomain> Win32UserInDomain { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_UserProfile</c> collection
        /// </summary>
        public WmiClassSet<Win32UserProfile> Win32UserProfile { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_UserStateConfigurationControls</c> collection
        /// </summary>
        public WmiClassSet<Win32UserStateConfigurationControls> Win32UserStateConfigurationControls { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_UTCTime</c> collection
        /// </summary>
        public WmiClassSet<Win32UtcTime> Win32UtcTime { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_VideoConfiguration</c> collection
        /// </summary>
        public WmiClassSet<Win32VideoConfiguration> Win32VideoConfiguration { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_VideoController</c> collection
        /// </summary>
        public WmiClassSet<Win32VideoController> Win32VideoController { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_VideoSettings</c> collection
        /// </summary>
        public WmiClassSet<Win32VideoSettings> Win32VideoSettings { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_VoltageProbe</c> collection
        /// </summary>
        public WmiClassSet<Win32VoltageProbe> Win32VoltageProbe { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_Volume</c> collection
        /// </summary>
        public WmiClassSet<Win32Volume> Win32Volume { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_VolumeChangeEvent</c> collection
        /// </summary>
        public WmiClassSet<Win32VolumeChangeEvent> Win32VolumeChangeEvent { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_VolumeQuota</c> collection
        /// </summary>
        public WmiClassSet<Win32VolumeQuota> Win32VolumeQuota { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_VolumeQuotaSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32VolumeQuotaSetting> Win32VolumeQuotaSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_VolumeUserQuota</c> collection
        /// </summary>
        public WmiClassSet<Win32VolumeUserQuota> Win32VolumeUserQuota { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_WinSAT</c> collection
        /// </summary>
        public WmiClassSet<Win32WinSat> Win32WinSat { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_WMIElementSetting</c> collection
        /// </summary>
        public WmiClassSet<Win32WmiElementSetting> Win32WmiElementSetting { get; set; }

        /// <summary>
        /// Representation of WMI class <c>Win32_WMISetting</c> collection
        /// </summary>
        public WmiClassSet<Win32WmiSetting> Win32WmiSetting { get; set; }
    }
}