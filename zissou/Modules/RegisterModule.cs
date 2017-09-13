namespace zissou
{
    using Nancy;
    using zissou.Handlers;
    using zissou.Models;
    using Nancy.ModelBinding;

    public class RegisterModule : NancyModule
    {
        public RegisterModule()
        {
            Post("/register", async (args) => {
                return await RegisterHandler.RegisterApplication(this.Bind<Application>(), Services.RegisterService.Create); 
            });
        }

    }
}
