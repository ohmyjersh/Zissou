using Nancy;
using Nancy.ModelBinding;
using zissou.Handlers;
using zissou.Models;

namespace zissou.Modules
{
    public class HealthModule : NancyModule
    {
        private ICacheManager<Dependency> _healthCache;
        public HealthModule(ICacheManager<Dependency> healthCache)
        {
            Put("/health/{appName}/{appId}", async (args) => {
				return await HealthHandler.UpdateApplicationStatus(this.Bind<Ping>(), Services.HealthService.Update);
			});
        }
    }
}
