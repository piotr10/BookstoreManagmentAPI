using BookstoreManagement.Application.Common.Interfaces;

namespace BookstoreManagement.Infrastructure.FileStore;

public class FileWrapper : IFileWrapper
{
    public void WriteAllBytes(string outputFile, byte[] content)
    {
        File.WriteAllBytes(outputFile, content);
    }
}