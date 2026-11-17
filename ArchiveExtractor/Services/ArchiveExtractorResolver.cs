using ArchiveExtractor.Core;

namespace ArchiveExtractor.Services;

public sealed class ArchiveExtractorResolver
{
    private readonly IEnumerable<IArchiveExtractor> _extractors;

    public ArchiveExtractorResolver(
        IEnumerable<IArchiveExtractor> extractors)
    {
        _extractors = extractors;
    }

    public IArchiveExtractor Resolve(
        string extension)
    {
        var extractor =
            _extractors.FirstOrDefault(
                e => e.CanHandle(extension));

        return extractor
               ?? throw new NotSupportedException(
                   $"Unsupported archive type: {extension}");
    }
}