namespace DateTimeUtils
{
    using Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using Services;

    public static class Extensions
    {
        /// <summary>
        /// Add DateTimeUtils dependency injection
        /// </summary>
        /// <param name="this">Service Collection</param>
        /// <returns>Service Collection with DateTimeUtils dependencies injected</returns>
        public static IServiceCollection AddDateTimeUtils(this IServiceCollection @this)
        {
            @this.TryAddSingleton<IDateTimeUtils, DateTimeUtils>();
            return @this;
        }
    }
}
