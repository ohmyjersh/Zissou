namespace zissou
{
    using Nancy;
    using zissou.Handlers;
    using Nancy.ModelBinding;

    public class RegisterModule : NancyModule
    {
        public RegisterModule()
        {
            Post("/register", async (args) => {
                return await RegisterHandler.RegisterApplication(BindThis<Application>(), Services.RegisterService.Create); 
            });
        }

        public T BindThis<T>() {
            T model = this.Bind();
            return model;
        }

    }
}
