$ErrorActionPreference = "Stop"

dotnet publish .\src\Illuminator.Cli -o .\publish -c release -r win-x64 -p:PublishSingleFile=true

.\publish\Illuminator.Cli.exe emit > .\src\Illuminator\ILEmitter.Emit.generated.cs
.\publish\Illuminator.Cli.exe core > .\src\Illuminator\ILEmitter.Core.generated.cs
.\publish\Illuminator.Cli.exe label > .\src\Illuminator.Extensions\LabelMethodsExtensions.generated.cs
