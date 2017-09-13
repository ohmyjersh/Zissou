using System.Threading.Tasks;
using zissou.Models;

namespace zissou.Services
{
    class HealthService
    {
        public static async Task<Health> Update(Ping ping) {
            return await Task.FromResult(new Health());
        }
    }
}