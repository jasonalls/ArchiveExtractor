# ArchiveExtractor

A Windows 11 Native AOT archive extraction utility providing an "Extract All Here" context menu option directly from Windows Explorer.

## Features

- ZIP extraction
- 7Z extraction
- RAR extraction
- TAR extraction
- GZIP extraction
- BZIP2 extraction
- XZ extraction
- Native AOT deployment
- SOLID architecture
- Dependency Injection
- Windows Explorer integration

## Technologies

- .NET 8
- Native AOT
- SharpCompress
- Microsoft Extensions Hosting
- Windows Explorer Context Menu

## Build

```powershell
dotnet restore
dotnet build
```

## Publish

```powershell
dotnet publish -c Release
```

## Installation

1. Copy the published executable to:

```text
C:\Program Files\ArchiveExtractor
```

2. Import:

```text
WindowsExplorerContextMenu.reg
```

3. Restart Windows Explorer.

## Supported Extensions

- .zip
- .7z
- .rar
- .tar
- .gz
- .tgz
- .bz2
- .xz

## License

MIT
