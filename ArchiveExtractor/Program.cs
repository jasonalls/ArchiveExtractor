using ArchiveExtractor.Core;
using ArchiveExtractor.Extractors;
using ArchiveExtractor.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder =
    Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<ArchiveService>();

builder.Services.AddSingleton<IArchiveExtractor,
    ZipExtractor>();

builder.Services.AddSingleton<IArchiveExtractor,
    GenericArchiveExtractor>();

builder.Services.AddSingleton<
    ArchiveExtractorResolver>();

builder.Services.AddSingleton<
    ExtractionRunner>();

using var host = builder.Build();

if (args.Length == 0)
{
    return;
}

var runner =
    host.Services.GetRequiredService<
        ExtractionRunner>();

await runner.RunAsync(
    args[0],
    CancellationToken.None);