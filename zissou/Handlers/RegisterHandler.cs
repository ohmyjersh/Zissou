using System;
using System.Net.Http;
using System.Threading.Tasks;
using zissou.Models;

namespace zissou.Handlers
{
    public class RegisterHandler
    {
        public static async Task<string> RegisterApplication(Application registerRequest, Func<Application, Task<string>> registerApplication)
        {
            try
            {
                var appId = await registerApplication(registerRequest);
                return appId;
            }
            catch (Exception ex)
            {
                return "error";
            }
        }
    }
}