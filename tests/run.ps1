param(
    [switch]$Recreate
)

$composeFile = Join-Path $PSScriptRoot 'docker-compose.yaml'

if (-not (Get-Command docker -ErrorAction SilentlyContinue)) {
    Write-Error 'Docker CLI not found. Please install Docker Desktop and ensure `"docker`" is on PATH.'
    exit 1
}

$flags = '--build'
if ($Recreate) { $flags += ' --force-recreate' }

$cmd = "docker compose -f `"$composeFile`" up -d $flags"
Write-Host "Running: $cmd"
Invoke-Expression $cmd

Write-Host 'Waiting for services to start...'
Start-Sleep -Seconds 3

Write-Host "Service status:"
Invoke-Expression "docker compose -f `"$composeFile`" ps"

Write-Host 'Docker compose started.'
