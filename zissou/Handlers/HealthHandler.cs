using System;
using System.Threading.Tasks;
using zissou.Models;

namespace zissou.Handlers
{
    public class HealthHandler
    {
        public static async Task<Health> UpdateApplicationStatus(Ping ping, Func<Ping, Task<Application>> updateApplication)
        {
            await updateApplication(ping);
            return new Health { Healthy = true };
        }
    }
}