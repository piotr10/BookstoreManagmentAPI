using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Persistance;

namespace BookstoreManagement.UnitTests.Common;

public class QueryTestFixtures : IDisposable
{
    public BookstoreDbContext Context { get; private set; }
    public IMapper Mapper { get; private set; }

    public QueryTestFixtures()
    {
        Context = BookstoreDbContextFactory.Create().Object;

        var configurationProvider = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<MappingProfile>();
        });

        Mapper = configurationProvider.CreateMapper();
    }
    public void Dispose()
    {
        BookstoreDbContextFactory.Destroy(Context);
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixtures>
    {

    }
}