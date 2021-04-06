using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using VNetDev.WmiQueryableCore.Exceptions;

namespace VNetDev.WmiQueryableCore
{
    /// <summary>
    /// Represents WMI object collection
    /// </summary>
    /// <typeparam name="T">WMI Class to be used in collection</typeparam>
    public class WmiClassSet<T>
        : IListSource, IOrderedQueryable<T>
    {
        private readonly WmiContext _context;

        /// <summary>
        /// Constructor that register WMI Context
        /// </summary>
        /// <param name="context">WMI Context instance to be registered</param>
        public WmiClassSet(WmiContext context)
        {
            _context = context;
            Expression = Expression.Constant(this);
        }

        /// <summary>
        /// Constructor that register WMI Context and takes prepared Expression
        /// </summary>
        /// <param name="context">WMI Context instance to be registered</param>
        /// <param name="expression">Initial Expression</param>
        public WmiClassSet(WmiContext context, Expression expression)
        {
            _context = context;
            Expression = expression;
        }

        /// <summary>
        /// WMI Context getter
        /// </summary>
        /// <returns>WMI Context registered in WMI Class Set</returns>
        public WmiContext GetContext() => _context;

        /// <summary>
        /// Casts current object to IQueryable object type
        /// </summary>
        /// <returns>IQueryable</returns>
        public virtual IQueryable<T> AsQueryable() => this;

        #region IQueryable interface implementation

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            try
            {
                return ((IEnumerable<T>) Provider.Execute(Expression)).GetEnumerator();
            }
            catch (NullReferenceException)
            {
                throw new WmiNotConnectedException();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                return ((IEnumerable<object>) Provider.Execute(Expression)).GetEnumerator();
            }
            catch (NullReferenceException)
            {
                throw new WmiNotConnectedException();
            }
        }

        /// <summary>
        /// Generic type of WMIClassSet
        /// </summary>
        public Type ElementType => typeof(T);

        /// <summary>
        /// LINQ Expression
        /// </summary>
        public Expression Expression { get; }

        /// <summary>
        /// Provider to be used to query object instances
        /// </summary>
        public IQueryProvider Provider => _context.Connection;

        #endregion

        #region IListSource interface implementation

        /// <summary>
        ///     This implementation always throws an exception.
        /// </summary>
        /// <exception cref="NotSupportedException"> Always thrown. </exception>
        /// <returns> Never returns, always throws an exception. </returns>
        IList IListSource.GetList()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        ///     Gets a value indicating whether the collection is a collection of System.Collections.IList objects.
        /// </summary>
        /// <returns> Always returns false. </returns>
        bool IListSource.ContainsListCollection => false;

        #endregion

        /// <summary>
        /// Creates WMI Object instances
        /// </summary>
        /// <returns>Created instance</returns>
        public T Create() => _context.CreateObjectInstance<T>();

        /// <summary>
        /// Saves WMI Object instance
        /// </summary>
        /// <param name="instance">Instance to save</param>
        public void Save(T instance) => _context.SaveObjectInstance<T>(instance);

        /// <summary>
        /// Deletes WMI Object instance
        /// </summary>
        /// <param name="instance">Instance to delete</param>
        public void Delete(T instance) => _context.DeleteObjectInstance<T>(instance);
    }
}