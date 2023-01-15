using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;

namespace VNetDev.WmiQueryableCore.Cim.Extensions
{
    /// <summary>
    /// WmiContextOptionsBuilder extension methods
    /// </summary>
    public static class WmiContextOptionsBuilderExtensions
    {
        /// <summary>
        /// Add Connection driver to use Windows Remote management
        /// </summary>
        /// <param name="optionsBuilder">WmiContextOptionsBuilder to extend</param>
        /// <param name="connection">Preconfigured <C>CimSession</C> object</param>
        /// <param name="nameSpace">WMI Namespace to work with</param>
        /// <returns>WmiContextOptionsBuilder (itself)</returns>
        public static WmiContextOptionsBuilder UseCim(
            this WmiContextOptionsBuilder optionsBuilder,
            CimSession connection, string nameSpace = @"root\CIMv2")
        {
            optionsBuilder.Options.Connection = new CimConnection(connection, nameSpace);
            return optionsBuilder;
        }

        /// <summary>
        /// Add Connection driver to use Windows Remote management
        /// </summary>
        /// <param name="optionsBuilder">WmiContextOptionsBuilder to extend</param>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">WMI Namespace to work with</param>
        /// <returns>WmiContextOptionsBuilder (itself)</returns>
        public static WmiContextOptionsBuilder UseCim(
            this WmiContextOptionsBuilder optionsBuilder,
            string computerName = ".", string nameSpace = @"root\CIMv2")
        {
            optionsBuilder.Options.Connection = new CimConnection(computerName, nameSpace);
            return optionsBuilder;
        }

        /// <summary>
        /// Add Connection driver to use Windows Remote management
        /// </summary>
        /// <param name="optionsBuilder">WmiContextOptionsBuilder to extend</param>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">WMI Namespace to work with</param>
        /// <param name="credential">Preconfigured <c>CimCredential</c> object</param>
        /// <returns>WmiContextOptionsBuilder (itself)</returns>
        public static WmiContextOptionsBuilder UseCim(
            this WmiContextOptionsBuilder optionsBuilder,
            string computerName, string nameSpace, CimCredential credential)
        {
            optionsBuilder.Options.Connection = new CimConnection(computerName, nameSpace, credential);
            return optionsBuilder;
        }

        /// <summary>
        /// Add Connection driver to use Windows Remote management
        /// </summary>
        /// <param name="optionsBuilder">WmiContextOptionsBuilder to extend</param>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">WMI Namespace to work with</param>
        /// <param name="authenticationMechanism">Authentication Mechanism</param>
        /// <param name="domain">User domain</param>
        /// <param name="userName">User name</param>
        /// <param name="password">User password</param>
        /// <returns></returns>
        public static WmiContextOptionsBuilder UseCim(
            this WmiContextOptionsBuilder optionsBuilder,
            string computerName, string nameSpace, PasswordAuthenticationMechanism authenticationMechanism,
            string domain, string userName, string password)
        {
            optionsBuilder.Options.Connection = new CimConnection(
                computerName, nameSpace, authenticationMechanism, domain, userName, password);
            return optionsBuilder;
        }
    }
}