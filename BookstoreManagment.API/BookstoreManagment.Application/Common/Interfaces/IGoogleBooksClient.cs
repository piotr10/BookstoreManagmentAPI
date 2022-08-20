namespace BookstoreManagement.Application.Common.Interfaces;

public interface IGoogleBooksClient
{
    Task<string> GetBook(string searchFilter, CancellationToken cancellationToken);
}