using System;
using Nancy;
using Nancy.TinyIoc;
using ServiceStack.Redis;
using zissou.Cache;
using zissou.Models;

namespace zissou
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
		protected override void ConfigureApplicationContainer(TinyIoCContainer container)
		{
			// Register our app dependency as a normal singleton
			container.Register<ICacheManager<Dependency>, HealthCache>().AsSingleton();
		}
    }
}
