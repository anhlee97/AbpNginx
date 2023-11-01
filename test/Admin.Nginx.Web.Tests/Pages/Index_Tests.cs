using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Admin.Nginx.Pages;

public class Index_Tests : NginxWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
