using System;

namespace VNetDev.WmiQueryableCore.WqlTranslator.Abstraction
{
    /// <summary>
    /// Represents WQL Query
    /// </summary>
    public interface IWqlQuery : IWqlClassObject
    {
        /// <summary>
        /// WQL Query return type
        /// </summary>
        Type WqlQueryResultType { get; }

        /// <summary>
        /// Mutates the object using all select statements
        /// </summary>
        /// <param name="input">WQL Query constructed object</param>
        /// <returns></returns>
        object ProceedDelegates(object input);
    }
}