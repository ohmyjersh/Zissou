using System;
using System.Threading.Tasks;
using Nancy;
using Nancy.ModelBinding;
using zissou.Handlers;
using zissou.Models;

namespace zissou.Modules
{
    public class HealthModule : NancyModule
    {
        public HealthModule()
        {
            Put("/health/{appName}/{appId}", async (args) => {
				return await HealthHandler.UpdateApplicationStatus(this.Bind<Ping>(), Services.HealthService.Update);
			});
        }
    }
}
