using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageResizing.AspCore.Helpers
{
   public static class Extensions
    {
        public static IServiceCollection AddImageResizingAspCore(this IServiceCollection services)
        {
            return services.AddMemoryCache();
        }

        public static IApplicationBuilder UseImageResizingAspCore(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ImageResizingAspCoreMiddleware>();
        }
    }
}
