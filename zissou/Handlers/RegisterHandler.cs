using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace zissou.Handlers
{
    public class RegisterHandler
    {
        public static async Task<string> RegisterApplication(RegisterRequest registerRequest, Func<RegisterRequest, Task<string>> registerApplication)
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