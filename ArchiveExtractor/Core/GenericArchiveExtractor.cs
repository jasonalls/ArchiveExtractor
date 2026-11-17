using ArchiveExtractor.Core;

namespace ArchiveExtractor.Extractors;

public sealed class GenericArchiveExtractor
    : IArchiveExtractor
{
    private readonly ArchiveService _archiveService;

    private static readonly string[] Extensions =
    [
        ".7z",
        ".rar",
        ".tar",
        ".gz",
        ".tgz",
        ".tar.gz",
        ".bz2",
        ".xz"
    ];

    public GenericArchiveExtractor(
        ArchiveService archiveService)
    {
        _archiveService = archiveService;
    }

    public bool CanHandle(string extension)
    {
        return Extensions.Contains(
            extension,
            StringComparer.OrdinalIgnoreCase);
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