namespace VNetDev.WmiQueryableCore
{
    /// <summary>
    /// WMI Context options builder default class
    /// </summary>
    public class WmiContextOptionsBuilder
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public WmiContextOptionsBuilder()
            : this(new WmiContextOptions<WmiContext>())
        {
        }

        /// <summary>
        /// Constructor that takes preconfigured options object
        /// </summary>
        /// <param name="options"></param>
        public WmiContextOptionsBuilder(WmiContextOptions options)
        {
            Options = options;
        }

        /// <summary>
        /// WMI Context Options object
        /// </summary>
        public WmiContextOptions Options { get; set; }

        /// <summary>
        /// Sets connection description
        /// </summary>
        /// <param name="comment">Description message</param>
        /// <returns></returns>
        public virtual WmiContextOptionsBuilder SetOptionsComment(string comment)
        {
            Options.OptionsComment = comment;
            return this;
        }
    }
}