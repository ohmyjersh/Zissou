using System;
using System.Threading.Tasks;
using Nancy;

namespace zissou.Modules
{
    public class HealthModule : NancyModule
    {
        public HealthModule()
        {
            Put("/health/{appName}/{appId}", async (args) => {
				return await HealthHandler.UpdateApplicationStatus(args.appName, args.appId, Services.HealthService.Update);
			});
        }
    }
}
