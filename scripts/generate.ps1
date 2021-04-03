$ErrorActionPreference = "Stop"

dotnet publish .\src\Illuminator.Cli -o .\publish -c release -r win-x64 -p:PublishSingleFile=true

.\publish\Illuminator.Cli.exe emit > .\src\Illuminator\ILEmitter.Emit.Generated.cs
.\publish\Illuminator.Cli.exe extensions > .\src\Illuminator\ILEmitter.Emit.Extensions.Generated.cs
.\publish\Illuminator.Cli.exe label > .\src\Illuminator\ILEmitter.Emit.Extensions.Label.Generated.cs
.\publish\Illuminator.Cli.exe core > .\src\Illuminator\ILEmitter.Core.Generated.cs
.\publish\Illuminator.Cli.exe functions > .\src\Illuminator\Functions.Generated.cs
