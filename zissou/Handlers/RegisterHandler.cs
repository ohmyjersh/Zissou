using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace zissou.Handlers
{
    public class RegisterHandler
    {
        public static async Task<string> RegisterApplication(RegisterRequest registerRequest, Func<RegisterRequest, Task> registerApplication)
        {
            
            return await Task.FromResult(registerRequest.Name);
                //await registerApplication(registerRequest);
        }
    }
}