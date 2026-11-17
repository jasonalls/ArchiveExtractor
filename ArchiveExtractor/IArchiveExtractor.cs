namespace ArchiveExtractor.Core;

public interface IArchiveExtractor
{
    bool CanHandle(string extension);

    Task ExtractAsync(
        string archivePath,
        string destinationFolder,
        CancellationToken cancellationToken);
}
