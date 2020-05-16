using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace VNetDev.WmiQueryableCore.Extensions
{
    /// <summary>
    /// Extension methods for <c>IServiceCollection</c>
    /// </summary>
    public static class WmiQueryableServiceCollectionExtension
    {
        // Reference: https://csharp.christiannagel.com/2016/07/27/diwithoptions/ (November 23, 2019)
        /// <summary>
        /// Registers WMIContext in dependency injection container
        /// </summary>
        /// <typeparam name="TContext">WMI Context type</typeparam>
        /// <param name="serviceCollection">Object to be extended</param>
        /// <param name="optionsAction">Action to configure connection options</param>
        /// <param name="contextLifetime">Lifetime of Context in dependency inject container</param>
        /// <param name="optionsLifetime">Lifetime of Context options in dependency inject container</param>
        /// <returns>Dependency injection collection</returns>
        public static IServiceCollection AddWmiContext<TContext>(
            this IServiceCollection serviceCollection,
            Action<WmiContextOptionsBuilder> optionsAction = null,
            ServiceLifetime contextLifetime = ServiceLifetime.Scoped,
            ServiceLifetime optionsLifetime = ServiceLifetime.Scoped)
            where TContext : WmiContext
        {
            serviceCollection.TryAdd(new ServiceDescriptor(
                typeof(WmiContextOptions<TContext>),
                p =>
                {
                    var builder = new WmiContextOptionsBuilder<TContext>(
                        new WmiContextOptions<TContext>());
                    optionsAction?.Invoke(builder);
                    return builder.Options;
                },
                optionsLifetime));
            serviceCollection.Add(new ServiceDescriptor(
                typeof(WmiContextOptions),
                p => p.GetRequiredService<WmiContextOptions<TContext>>(),
                optionsLifetime));

            serviceCollection.TryAdd(new ServiceDescriptor(
                typeof(TContext), typeof(TContext), contextLifetime));
            return serviceCollection;
        }
    }
}