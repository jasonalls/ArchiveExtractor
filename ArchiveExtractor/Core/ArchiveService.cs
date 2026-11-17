using SharpCompress.Archives;
using SharpCompress.Common;

namespace ArchiveExtractor.Core;

public sealed class ArchiveService
{
    public async Task ExtractAsync(
        string archivePath,
        string destinationFolder,
        CancellationToken cancellationToken)
    {
        using var archive =
            ArchiveFactory.Open(archivePath);

        foreach (var entry in archive.Entries)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (entry.IsDirectory)
                continue;

            entry.WriteToDirectory(
                destinationFolder,
                new ExtractionOptions
                {
                    ExtractFullPath = true,
                    Overwrite = true
                });
        }

        await Task.CompletedTask;
    }
}