using System;
using System.Threading.Tasks;
using Xunit;
//using Xunit.Should;
using zissou.Handlers;
using zissou.Models;

namespace zissou.tests
{
    
    public class HealthHandlerTests
    {
        Func<Ping, Task<Application>> _update;
        Ping _ping;
        string Name = "1234";
        public HealthHandlerTests()
        {
            _ping = new Ping
            {
                Name = Name,
                Id = "1234"
            };

            _update = (arg) => Task.FromResult(new Application
            {
                Name = Name
            });
        }
        [Fact]
        public async Task ShouldUpdateStatusForApplicationAndReturnHealth() {
            var response = await HealthHandler.UpdateApplicationStatus(_ping, _update);
            Assert.True(response.Healthy);
        }
    }
}
