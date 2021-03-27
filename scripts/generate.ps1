$ErrorActionPreference = "Stop"

dotnet publish .\src\Illuminator.Cli -o .\publish -c release -r win-x64 -p:PublishSingleFile=true

.\publish\Illuminator.Cli.exe emit > .\src\Illuminator\ILEmitter.Emit.Gen.cs
.\publish\Illuminator.Cli.exe core > .\src\Illuminator\ILEmitter.Core.Gen.cs
.\publish\Illuminator.Cli.exe fun-ex > .\src\Illuminator\FunExtensions.Gen.cs
.\publish\Illuminator.Cli.exe functions > .\src\Illuminator\Functions.Gen.cs
.\publish\Illuminator.Cli.exe label > .\src\Illuminator.Extensions\LabelMethodsExtensions.Gen.cs
