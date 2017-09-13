using System;
using System.Threading.Tasks;

namespace zissou.Services
{
    public class RegisterService
    {
        public static Task<string> Create(RegisterRequest registerRequest)
        {
            return Task.FromResult(Guid.NewGuid().ToString());
        }
    }
}
