param(
    [string][Alias("c")]$configuration = "Debug",
    [switch][Alias("t")]$transform = $false,
    [switch][Alias("test")]$runTest = $false,
    [switch][Alias("p")]$publish = $false,
    [switch][Alias("cc")]$clean = $false
)

$ErrorActionPreference = "Stop"

if ($clean) {
    .\scripts\clean.ps1 -cc
}

if ($transform) {
    Write-Host "`nTransforming..." -ForegroundColor Green
    .\scripts\generate.ps1
    Write-Host
}

Write-Host "Building..." -ForegroundColor Green
dotnet build .\src\Illuminator.sln -c $configuration

if ($runTest) {
    Write-Host "`nTesting..." -ForegroundColor Green
    Get-ChildItem .\**\*.Tests.csproj -Recurse | ForEach-Object {
        dotnet test $_ -c $configuration --no-build
    }
}

if ($publish) {
    dotnet pack .\src\Illuminator.sln --include-source --include-symbols --no-build --no-dependencies -c $configuration -o .\publish
}

Write-Host "`nDone.`n" -ForegroundColor Green
