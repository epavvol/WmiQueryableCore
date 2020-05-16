namespace VNetDev.WmiQueryableCore.WqlTranslator.Abstraction
{
    /// <summary>
    /// WQL Query element
    /// </summary>
    public interface IWqlObject
    {
        /// <summary>
        /// Set element value
        /// </summary>
        /// <param name="values">Value(s) to be set</param>
        /// <returns>IWqlObject (itself)</returns>
        IWqlObject SetValue(params object[] values);
    }
}