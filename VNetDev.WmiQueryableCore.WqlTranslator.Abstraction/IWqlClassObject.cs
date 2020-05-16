namespace VNetDev.WmiQueryableCore.WqlTranslator.Abstraction
{
    /// <summary>
    /// WQL Class object, any WMI class used in query from or join operations
    /// </summary>
    public interface IWqlClassObject : IWqlObject
    {
        /// <summary>
        /// Adds predicate to filter objects
        /// </summary>
        /// <param name="predicate">Predicate to add</param>
        /// <returns>IWqlClassObject (itself)</returns>
        IWqlClassObject AddPredicate(IWqlPredicate predicate);

        /// <summary>
        /// Provides current object alias
        /// </summary>
        /// <param name="followedBy">string to append to alias</param>
        /// <returns>Object alias</returns>
        string GetAlias(string followedBy = null);
    }
}