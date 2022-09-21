using BookstoreManagement.Application.Author.Queries.GetAuthorDetail;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Shouldly;
using WebApi.IntegrationTests.Common;

namespace WebApi.IntegrationTests.Controllers.Authors;

public class GetDetailsTests : IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly CustomWebApplicationFactory<Program> _factory;

    public GetDetailsTests(CustomWebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task GivenAuthorsId_ReturnsAuthorsDetail()
    {
        var client = await _factory.GetAuthenticatedClientAsync();

        int id = 1;
        var response = await client.GetAsync($"/api/authors/{id}");
        response.EnsureSuccessStatusCode();

        var vm = await Utilities.GetResponseContent<AuthorDetailVm>(response);
        vm.ShouldNotBeNull();
    }
}