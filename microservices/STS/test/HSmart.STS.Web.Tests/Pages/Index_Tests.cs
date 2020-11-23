using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace HSmart.STS.Pages
{
    public class Index_Tests : STSWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
