using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using zissou.Handlers;

namespace zissou.tests
{
    public class RegisterHandlerTests
    {
        private Func<Application, Task> _createApplication;
        private Application _registerRequest;

        RegisterHandlerTests()
        {
            _createApplication = (request) => Task.CompletedTask;
            _registerRequest = new Application
            {
                Name = "Application",
                Server = "Server-1",
                Dependencies = new System.Collections.Generic.List<Dependency> {
                    new Dependency {
                        Name = "Dep 1",
                        Version = "1.1.0.1"
                    }
                },
                Metadata = new Dictionary<string, string> {
                    {"key", "value"},
                    {"anotherKey", "anotherValue"}
                }
            };
        }
        [Fact]
        public async Task ShouldReturnOkForSuccessfulRegisterOfApplication()
        {
           // var response = await RegisterHandler.RegisterApplication(_registerRequest, _createApplication);
           // Assert.Equal(response.ExecuteResultAsync().);
        }
    }
}
