$ErrorActionPreference = "Stop"

dotnet publish .\src\Illuminator.Cli -o .\publish\Illuminator.Cli -c release -r win-x64 -p:PublishSingleFile=true
