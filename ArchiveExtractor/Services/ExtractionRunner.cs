namespace ArchiveExtractor.Services;

public sealed class ExtractionRunner
{
    private readonly ArchiveExtractorResolver _resolver;

    public ExtractionRunner(
        ArchiveExtractorResolver resolver)
    {
        _resolver = resolver;
    }

    public async Task RunAsync(
        string archivePath,
        CancellationToken cancellationToken)
    {
        var extension =
            Path.GetExtension(archivePath);

        var destination =
            Path.GetDirectoryName(archivePath)!;

        var extractor =
            _resolver.Resolve(extension);

        await extractor.ExtractAsync(
            archivePath,
            destination,
            cancellationToken);
    }
}