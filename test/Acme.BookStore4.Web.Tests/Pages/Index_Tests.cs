using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.BookStore4.Pages
{
    public class Index_Tests : BookStore4WebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
