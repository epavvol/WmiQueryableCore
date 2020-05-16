using System.Linq.Expressions;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;
using VNetDev.WmiQueryableCore.WqlTranslator.Types;

namespace VNetDev.WmiQueryableCore.WqlTranslator
{
    /// <summary>
    /// WqlTranslator Query Factory
    /// </summary>
    public class WqlFactory : IWqlFactory
    {
        /// <summary>
        /// Translates LINQ Expression into WMI Query object using WqlTranslator
        /// </summary>
        /// <param name="expression">Expression to be translated</param>
        /// <returns>IWqlQuery object</returns>
        public IWqlQuery TranslateQuery(Expression expression) =>
            new WqlTranslator()
                .Translate(expression);

        internal static IWqlPredicate GetPredicate() => new WqlPredicate();
        internal static WqlValue GetValueObject() => new WqlValue();
    }
}