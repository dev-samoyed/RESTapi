using Microsoft.Extensions.DependencyInjection;

namespace RESTapi.Common.Interfaces
{
    public interface IPlatformInitializer
    {
        void ConfigureServices(IServiceCollection services);
    }
}
