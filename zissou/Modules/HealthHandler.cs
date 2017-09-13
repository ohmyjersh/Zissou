using System;
using System.Threading.Tasks;

namespace zissou.Modules
{
    internal class HealthHandler
    {
        internal static async Task<RegisterRequest> UpdateApplicationStatus(string appName, string appId, Func<string, string, Task<RegisterRequest>> updateApplication)
        {
            return await updateApplication(appName, appId);
        }
    }
}