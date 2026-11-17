using ArchiveExtractor.Core;

namespace ArchiveExtractor.Extractors;

public sealed class ZipExtractor : IArchiveExtractor
{
    private readonly ArchiveService _archiveService;

    public ZipExtractor(
        ArchiveService archiveService)
    {
        _archiveService = archiveService;
    }

    public bool CanHandle(string extension)
    {
        return extension.Equals(
            ".zip",
            StringComparison.OrdinalIgnoreCase);
    }

    public Task ExtractAsync(
        string archivePath,
        string destinationFolder,
        CancellationToken cancellationToken)
    {
        return _archiveService.ExtractAsync(
            archivePath,
            destinationFolder,
            cancellationToken);
    }
}