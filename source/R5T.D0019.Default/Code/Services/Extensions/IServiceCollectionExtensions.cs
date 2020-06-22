using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0019.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileTransformer"/> implementation of <see cref="IVisualStudioProjectFileTransformer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioProjectFileTransformer(this IServiceCollection services)
        {
            services.AddSingleton<IVisualStudioProjectFileTransformer, VisualStudioProjectFileTransformer>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileTransformer"/> implementation of <see cref="IVisualStudioProjectFileTransformer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioProjectFileTransformer> AddVisualStudioProjectFileTransformerAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IVisualStudioProjectFileTransformer>.New(() => services.AddVisualStudioProjectFileTransformer());
            return serviceAction;
        }
    }
}
