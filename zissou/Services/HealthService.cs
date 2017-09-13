using System.Threading.Tasks;
using zissou.Models;

namespace zissou.Services
{
    class HealthService
    {
        public static async Task<Application> Update(Ping ping) {
            return await Task.FromResult(new Application());
        }
    }
}