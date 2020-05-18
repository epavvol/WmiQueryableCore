using System.Management;

namespace VNetDev.WmiQueryableCore.DCom.Extensions
{
    /// <summary>
    /// WmiContextOptionsBuilder extension methods
    /// </summary>
    public static class WmiContextOptionsBuilderExtension
    {
        /// <summary>
        /// Add Connection driver to use DCom connection
        /// </summary>
        /// <param name="optionsBuilder">WmiContextOptionsBuilder to extend</param>
        /// <param name="connection">Preconfigured <c>ManagementScope</c> object</param>
        /// <returns>WmiContextOptionsBuilder (itself)</returns>
        public static WmiContextOptionsBuilder UseDCom(
            this WmiContextOptionsBuilder optionsBuilder,
            ManagementScope connection)
        {
            optionsBuilder.Options.Connection = new DComConnection(connection);
            return optionsBuilder;
        }

        /// <summary>
        /// Add Connection driver to use DCom connection
        /// </summary>
        /// <param name="optionsBuilder">WmiContextOptionsBuilder to extend</param>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">WMI Namespace to work with</param>
        /// <returns>WmiContextOptionsBuilder (itself)</returns>
        public static WmiContextOptionsBuilder UseDCom(
            this WmiContextOptionsBuilder optionsBuilder,
            string computerName = ".", string nameSpace = @"root\CIMv2")
        {
            optionsBuilder.Options.Connection = new DComConnection(computerName, nameSpace);
            return optionsBuilder;
        }

        /// <summary>
        /// Add Connection driver to use DCom connection
        /// </summary>
        /// <param name="optionsBuilder">WmiContextOptionsBuilder to extend</param>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">WMI Namespace to work with</param>
        /// <param name="options">Preconfigured <c>ConnectionOptions</c> object</param>
        /// <returns>WmiContextOptionsBuilder (itself)</returns>
        public static WmiContextOptionsBuilder UseDCom(
            this WmiContextOptionsBuilder optionsBuilder,
            string computerName, string nameSpace, ConnectionOptions options)
        {
            optionsBuilder.Options.Connection = new DComConnection(computerName, nameSpace, options);
            return optionsBuilder;
        }

        /// <summary>
        /// Add Connection driver to use DCom connection
        /// </summary>
        /// <param name="optionsBuilder">WmiContextOptionsBuilder to extend</param>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">WMI Namespace to work with</param>
        /// <param name="impersonationLevel">Impersonation level</param>
        /// <param name="domain">User domain</param>
        /// <param name="userName">User name</param>
        /// <param name="password">User password</param>
        /// <returns></returns>
        public static WmiContextOptionsBuilder UseDCom(
            this WmiContextOptionsBuilder optionsBuilder,
            string computerName, string nameSpace,
            string domain, string userName, string password,
            ImpersonationLevel impersonationLevel = ImpersonationLevel.Impersonate)
        {
            optionsBuilder.Options.Connection = new DComConnection(
                computerName, nameSpace, domain, userName, password, impersonationLevel);
            return optionsBuilder;
        }
    }
}