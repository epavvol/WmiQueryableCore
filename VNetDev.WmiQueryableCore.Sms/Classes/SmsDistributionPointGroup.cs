using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DistributionPointGroup
    /// </summary>
    [WmiClass(Name = "SMS_DistributionPointGroup")]
    public class SmsDistributionPointGroup
    {
        /// <summary>
        /// WMI method <c>AddPackages</c> describing delegate.
        /// <param name="packageIDs">WMI Property <c>PackageIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddPackagesDelegate(ICollection<string> packageIDs = default);
        /// <summary>
        /// WMI method <c>AddPackages</c>.
        /// </summary>
        public AddPackagesDelegate AddPackages;
        
        /// <summary>
        /// WMI method <c>RemovePackages</c> describing delegate.
        /// <param name="packageIDs">WMI Property <c>PackageIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="removePackageFromDPs">WMI Property <c>RemovePackageFromDPs</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemovePackagesDelegate(ICollection<string> packageIDs = default, bool removePackageFromDPs = default);
        /// <summary>
        /// WMI method <c>RemovePackages</c>.
        /// </summary>
        public RemovePackagesDelegate RemovePackages;
        
        /// <summary>
        /// WMI method <c>AddDistributionPoints</c> describing delegate.
        /// <param name="addTargetedPackages">WMI Property <c>AddTargetedPackages</c> of type <c>bool</c>.</param>
        /// <param name="dpnalPath">WMI Property <c>DPNALPath</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddDistributionPointsDelegate(bool addTargetedPackages = default, ICollection<string> dpnalPath = default);
        /// <summary>
        /// WMI method <c>AddDistributionPoints</c>.
        /// </summary>
        public AddDistributionPointsDelegate AddDistributionPoints;
        
        /// <summary>
        /// WMI method <c>RemoveDistributionPoints</c> describing delegate.
        /// <param name="dpnalPath">WMI Property <c>DPNALPath</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="removeTargetedPackages">WMI Property <c>RemoveTargetedPackages</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveDistributionPointsDelegate(ICollection<string> dpnalPath = default, bool removeTargetedPackages = default);
        /// <summary>
        /// WMI method <c>RemoveDistributionPoints</c>.
        /// </summary>
        public RemoveDistributionPointsDelegate RemoveDistributionPoints;
        
        /// <summary>
        /// WMI method <c>AssociateCollections</c> describing delegate.
        /// <param name="collectionId">WMI Property <c>CollectionID</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AssociateCollectionsDelegate(ICollection<string> collectionId = default);
        /// <summary>
        /// WMI method <c>AssociateCollections</c>.
        /// </summary>
        public AssociateCollectionsDelegate AssociateCollections;
        
        /// <summary>
        /// WMI method <c>DisassociateCollections</c> describing delegate.
        /// <param name="collectionId">WMI Property <c>CollectionID</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DisassociateCollectionsDelegate(ICollection<string> collectionId = default);
        /// <summary>
        /// WMI method <c>DisassociateCollections</c>.
        /// </summary>
        public DisassociateCollectionsDelegate DisassociateCollections;
        
        /// <summary>
        /// WMI method <c>RefreshDPGroup</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RefreshDpGroupDelegate();
        /// <summary>
        /// WMI method <c>RefreshDPGroup</c>.
        /// </summary>
        public RefreshDpGroupDelegate RefreshDpGroup;
        
        /// <summary>
        /// WMI method <c>ReDistributePackage</c> describing delegate.
        /// <param name="packageId">WMI Property <c>PackageID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReDistributePackageDelegate(string packageId = default);
        /// <summary>
        /// WMI method <c>ReDistributePackage</c>.
        /// </summary>
        public ReDistributePackageDelegate ReDistributePackage;
        
        /// <summary>
        /// WMI method <c>EnableDistributionPointUpgrade</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EnableDistributionPointUpgradeDelegate();
        /// <summary>
        /// WMI method <c>EnableDistributionPointUpgrade</c>.
        /// </summary>
        public EnableDistributionPointUpgradeDelegate EnableDistributionPointUpgrade;
        /// <summary>
        /// WMI Property CollectionCount
        /// </summary>
        public uint CollectionCount { get; set; }
        /// <summary>
        /// WMI Property ContentCount
        /// </summary>
        public uint ContentCount { get; set; }
        /// <summary>
        /// WMI Property ContentInSync
        /// </summary>
        public bool ContentInSync { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property CreatedOn
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property HasMember
        /// </summary>
        public bool HasMember { get; set; }
        /// <summary>
        /// WMI Property HasRelationship
        /// </summary>
        public bool HasRelationship { get; set; }
        /// <summary>
        /// WMI Property MemberCount
        /// </summary>
        public uint MemberCount { get; set; }
        /// <summary>
        /// WMI Property ModifiedBy
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// WMI Property ModifiedOn
        /// </summary>
        public DateTime ModifiedOn { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OutOfSyncContentCount
        /// </summary>
        public uint OutOfSyncContentCount { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
