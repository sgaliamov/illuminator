$ErrorActionPreference = "Stop"

dotnet publish .\src\Illuminator.Cli -o .\publish -c release -r win-x64 -p:PublishSingleFile=true

.\publish\Illuminator.Cli.exe named > .\src\Illuminator\ILEmitter.Core.generated.cs
