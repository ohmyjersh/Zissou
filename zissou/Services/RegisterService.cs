using System;
using System.Threading.Tasks;
using zissou.Models;

namespace zissou.Services
{
    public class RegisterService
    {
        public static Task<string> Create(Application registerRequest)
        {
            return Task.FromResult(Guid.NewGuid().ToString());
        }
    }
}
