namespace VNetDev.WmiQueryableCore.WqlTranslator.Abstraction
{
    /// <summary>
    /// WQL Query Predicate element
    /// </summary>
    public interface IWqlPredicate : IWqlObject
    {
        /// <summary>
        /// Sets left part of predicate
        /// </summary>
        /// <param name="left">Predicate value</param>
        /// <returns>IWqlPredicate (itself)</returns>
        IWqlPredicate SetLeft(IWqlObject left);

        /// <summary>
        /// Sets right part of predicate
        /// </summary>
        /// <param name="right">Predicate value</param>
        /// <returns>IWqlPredicate (itself)</returns>
        IWqlPredicate SetRight(IWqlObject right);

        /// <summary>
        /// Predicate comparison operator
        /// </summary>
        /// <param name="op">Comparison operator</param>
        /// <returns>IWqlPredicate (itself)</returns>
        IWqlPredicate SetOperator(string op);
    }
}