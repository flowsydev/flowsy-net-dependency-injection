using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Flowsy.DependencyInjection;

public static class ServiceExtensions
{
    public static T GetTaggedService<T>(this IServiceProvider serviceProvider, string tag)
    {
        return serviceProvider.GetServices<T>()
            .Where(s =>
            {
                var attribute = s?.GetType().GetCustomAttribute<ServiceTagAttribute>();
                return attribute != null && attribute.Value == tag;
            })
            .First();
    }
}