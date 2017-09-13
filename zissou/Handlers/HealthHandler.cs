using System;
using System.Threading.Tasks;
using zissou.Models;

namespace zissou.Modules
{
    internal class HealthHandler
    {
        internal static async Task<Health> UpdateApplicationStatus(Ping ping, Func<Ping, Task<Health>> updateApplication)
        {
            return await updateApplication(ping);
        }
    }
}