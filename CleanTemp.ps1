#requires -Version 5.1
[CmdletBinding()]
param([switch]$DryRun, [string]$LogPath = 'C:\Logs\CleanTemp.log')

$ErrorActionPreference = 'SilentlyContinue'
$script:DeletedFileCount = 0
$script:FreedBytes = [int64]0
$script:ErrorCount = 0

function Write-Log {
    param([string]$Message, [ValidateSet('INFO','WARN','ERROR')][string]$Level = 'INFO')
    try {
        $directory = Split-Path -Parent $LogPath
        if ($directory) { New-Item -ItemType Directory -Path $directory -Force | Out-Null }
        Add-Content -LiteralPath $LogPath -Value ('{0} [{1}] {2}' -f (Get-Date -Format 'yyyy-MM-dd HH:mm:ss'), $Level, $Message) -Encoding UTF8
    } catch { }
}

function Remove-Contents {
    param([string]$Path, [string]$Description)
    if (-not (Test-Path -LiteralPath $Path -PathType Container)) { Write-Log "$Description skipped; folder not found: $Path" WARN; return }
    Write-Log "Scanning [$Description]: $Path"
    try { $items = Get-ChildItem -LiteralPath $Path -Force -Recurse -ErrorAction SilentlyContinue } catch { Write-Log "Could not enumerate [$Description]: $Path" ERROR; $script:ErrorCount++; return }
    foreach ($item in $items | Sort-Object { $_.FullName.Length } -Descending) {
        try {
            if (($item.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) { continue }
            if ($DryRun) { Write-Log "DRY-RUN: would remove [$Description] $($item.FullName)"; continue }
            $size = if ($item -is [IO.FileInfo]) { [int64]$item.Length } else { [int64]0 }
            Remove-Item -LiteralPath $item.FullName -Force -Recurse -ErrorAction Stop
            $script:DeletedFileCount++; $script:FreedBytes += $size
        } catch { $script:ErrorCount++; Write-Log "Skipped locked/protected item [$Description]: $($item.FullName)" WARN }
    }
}

$targets = @(
    @{ Description = 'Temporary files'; Paths = @((Join-Path $env:LOCALAPPDATA 'Temp'), 'C:\Windows\Temp') },
    @{ Description = 'Windows Defender temporary files'; Paths = @('C:\ProgramData\Microsoft\Windows Defender\Scans\History\Service') },
    @{ Description = 'Windows Update cache'; Paths = @('C:\Windows\SoftwareDistribution\Download') },
    @{ Description = 'SYSTEM temporary files'; Paths = @('C:\Windows\SystemTemp') }
)
Write-Log (if ($DryRun) { 'Cleanup started in DRY-RUN mode.' } else { 'Cleanup started.' })
foreach ($target in $targets) { foreach ($path in $target.Paths) { Remove-Contents -Path $path -Description $target.Description } }

$recyclePath = 'C:\$Recycle.Bin'
if (Test-Path -LiteralPath $recyclePath -PathType Container) { Remove-Contents -Path $recyclePath -Description 'Recycle Bin' } else { Write-Log "Recycle Bin folder not found: $recyclePath" WARN }

$freedMb = [math]::Round($script:FreedBytes / 1MB, 2)
Write-Log ("Cleanup completed. Items removed: {0}; estimated space: {1} MB; skipped/errors: {2}" -f $script:DeletedFileCount, $freedMb, $script:ErrorCount)
