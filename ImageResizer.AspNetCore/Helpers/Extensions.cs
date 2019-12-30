using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SkiaSharp;

namespace ImageResizer.AspNetCore.Helpers
{
    public static class Extensions
    {
        public static IServiceCollection AddImageResizer(this IServiceCollection services)
        {
            return services.AddMemoryCache();
        }

        public static IApplicationBuilder UseImageResizer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ImageResizerMiddleware>();
        }

        internal static SKTextAlign GetSKTextAlign(this short align)
        {
            switch (align)
            {
                case 1:
                    return SKTextAlign.Right;
                case 2:
                    return SKTextAlign.Center;
                case 3:
                    return SKTextAlign.Left;
                default:
                    return SKTextAlign.Center;
            }
        }
        internal static SKFilterQuality GetSKFilterQuality(this short quality)
        {
            switch (quality)
            {
                case 1:
                    return SKFilterQuality.None;
                case 2:
                    return SKFilterQuality.Low;
                case 3:
                    return SKFilterQuality.Medium;
                case 4:
                    return SKFilterQuality.High;
                default:
                    return SKFilterQuality.Medium;
            }
        }
        internal static SKPaintStyle GetSKPaintStyle(this short type)
        {
            switch (type)
            {
                case 1:
                    return SKPaintStyle.Fill;
                case 2:
                    return SKPaintStyle.Stroke;
                case 3:
                    return SKPaintStyle.StrokeAndFill;
                default:
                    return SKPaintStyle.Fill;
            }
        }
        internal static float ToPixel(this float persent, float imageXOrY)
        {
                return (imageXOrY * persent) / 100;
        }
    }
}
