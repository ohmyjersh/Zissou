namespace zissou
{
    using Nancy;
    using zissou.Handlers;

    public class RegisterModule : NancyModule
    {
        public RegisterModule()
        {
            Get("/register", async (args) => await RegisterHandler.RegisterApplication(args as RegisterRequest, Services.RegisterService.Create));
        }
    }
}
