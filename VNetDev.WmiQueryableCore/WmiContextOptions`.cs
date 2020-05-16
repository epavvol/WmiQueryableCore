namespace VNetDev.WmiQueryableCore
{
    /// <summary>
    /// WMI Context Options generic class
    /// <typeparam name="TWmiContext">WMI Context type to be configured</typeparam>
    /// </summary>
    public class WmiContextOptions<TWmiContext> : WmiContextOptions
        where TWmiContext : WmiContext
    {
    }
}