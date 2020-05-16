using System.Linq.Expressions;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Abstraction
{
    /// <summary>
    /// WQL Translation Factory
    /// </summary>
    public interface IWqlFactory
    {
        /// <summary>
        /// Translates LINQ Expression into WMI Query object
        /// </summary>
        /// <param name="expression">Expression to be translated</param>
        /// <returns>IWqlQuery object</returns>
        IWqlQuery TranslateQuery(Expression expression);
    }
}