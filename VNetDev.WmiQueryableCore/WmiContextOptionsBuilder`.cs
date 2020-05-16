namespace VNetDev.WmiQueryableCore
{
    /// <summary>
    /// WMI Context options builder generic class
    /// <typeparam name="TWmiContext">WMI Context object to be configured</typeparam>
    /// </summary>
    public class WmiContextOptionsBuilder<TWmiContext> : WmiContextOptionsBuilder
        where TWmiContext : WmiContext
    {
        /// <summary>
        /// Constructor that takes preconfigured options object
        /// </summary>
        /// <param name="options"></param>
        public WmiContextOptionsBuilder(WmiContextOptions<TWmiContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public WmiContextOptionsBuilder() : base(new WmiContextOptions<TWmiContext>())
        {
        }

        /// <summary>
        /// WMI Context Options object
        /// </summary>
        public new virtual WmiContextOptions<TWmiContext> Options => (WmiContextOptions<TWmiContext>) base.Options;

        /// <summary>
        /// Sets connection description
        /// </summary>
        /// <param name="comment">Description message</param>
        /// <returns></returns>
        public new virtual WmiContextOptionsBuilder<TWmiContext> SetOptionsComment(string comment) =>
            (WmiContextOptionsBuilder<TWmiContext>) base.SetOptionsComment(comment);
    }
}