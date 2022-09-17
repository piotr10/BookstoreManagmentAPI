using BookstoreManagement.Persistance;
using Moq;

namespace BookstoreManagement.UnitTests.Common;

public class CommandTestBase : IDisposable
{
    protected readonly BookstoreDbContext _context;
    protected readonly Mock<BookstoreDbContext> _contextMock;

    public CommandTestBase()
    {
        _contextMock = BookstoreDbContextFactory.Create();
        _context = _contextMock.Object;
    }

    public void Dispose()
    {
        BookstoreDbContextFactory.Destroy(_context);
    }
}