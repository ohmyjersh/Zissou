using System.Threading.Tasks;

namespace zissou.Services
{
    internal class HealthService
    {
        public static async Task<Application> Update(string appName, string appId) {
            return await Task.FromResult(new Application());
        }
    }
}