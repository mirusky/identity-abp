using System.Threading.Tasks;
using template.Models.TokenAuth;
using template.Web.Controllers;
using Shouldly;
using Xunit;

namespace template.Web.Tests.Controllers
{
    public class HomeController_Tests: templateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}