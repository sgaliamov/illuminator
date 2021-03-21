$ErrorActionPreference = "Stop"

Get-ChildItem -Include "bin", "obj", "TestResults", "coveragereport" -Recurse -Force -Directory | Remove-Item -Force -Recurse

dotnet test .\src --collect:"XPlat Code Coverage"

Get-ChildItem ".\src\**\TestResults\*\coverage.cobertura.xml" | ForEach-Object {
    reportgenerator `
        "-reports:$_" `
        "-targetdir:coveragereport" `
        -reporttypes:Html
}

.\coveragereport\index.html
