using System;
using System.Threading.Tasks;
using zissou.Models;

namespace zissou.Services
{
    public class RegisterService
    {
        public static Task<string> Create(Register registerRequest)
        {
            return Task.FromResult(Guid.NewGuid().ToString());
        }
    }
}
