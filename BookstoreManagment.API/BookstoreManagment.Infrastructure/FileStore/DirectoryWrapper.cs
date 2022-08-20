using BookstoreManagement.Application.Common.Interfaces;

namespace BookstoreManagement.Infrastructure.FileStore;

public class DirectoryWrapper : IDirectoryWrapper
{
    public void CreateDirectory(string path)
    {
        Directory.CreateDirectory(path);
    }
}