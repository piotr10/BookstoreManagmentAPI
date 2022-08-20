﻿using BookstoreManagement.Application.Common.Interfaces;

namespace BookstoreManagement.Infrastructure.FileStore;

public class FileStore : IFileStore
{
    private readonly IFileWrapper _fileWrapper;
    private readonly IDirectoryWrapper _directoryWrapper;

    public FileStore(IFileWrapper fileWrapper, IDirectoryWrapper directoryWrapper)
    {
        _fileWrapper = fileWrapper;
        _directoryWrapper = directoryWrapper;
    }

    public string SafeWriteFile(byte[] content, string sourceFileName, string path)
    {
        _directoryWrapper.CreateDirectory(path);
        var outputFile = Path.Combine(path, sourceFileName);
        _fileWrapper.WriteAllBytes(outputFile, content);
        return outputFile;
    }
}