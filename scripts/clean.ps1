param(
    [switch][Alias("cc")]$cleanCode
)

$ErrorActionPreference = "Stop"

Get-ChildItem -Include bin, obj, publish -Recurse | Remove-Item -Force -Recurse

if ($cleanCode) {
    Get-ChildItem -Include "*.Generated.cs" -Recurse | Remove-Item -Force -Recurse
}

Write-Host "Cleaned." -ForegroundColor Green
