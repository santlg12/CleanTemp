#requires -Version 5.1

[CmdletBinding()]
param(
    [string]$CleanupScriptPath = (Join-Path -Path $PSScriptRoot -ChildPath 'CleanTemp.ps1'),
    [string]$TaskName = 'PuliziaFileTemporanei',
    [ValidateSet('Daily', 'Hours', 'Days')]
    [string]$Schedule = 'Daily',
    [ValidateRange(1, 365)]
    [int]$Interval = 1,
    [datetime]$StartTime = (Get-Date).Date.AddHours(3),
    [switch]$AddStartupTrigger
)

$ErrorActionPreference = 'Stop'
try {
    if (-not (Test-Path -LiteralPath $CleanupScriptPath -PathType Leaf)) { throw "Script di pulizia non trovato: $CleanupScriptPath" }
    $cleanupFullPath = (Get-Item -LiteralPath $CleanupScriptPath -Force).FullName
    $powerShellExe = Join-Path -Path $PSHOME -ChildPath 'powershell.exe'
    $actionArguments = '-NoLogo -NoProfile -NonInteractive -ExecutionPolicy Bypass -WindowStyle Hidden -File "{0}"' -f $cleanupFullPath
    $action = New-ScheduledTaskAction -Execute $powerShellExe -Argument $actionArguments
    $triggers = @()
    switch ($Schedule) {
        'Daily' { $triggers += New-ScheduledTaskTrigger -Daily -DaysInterval 1 -At $StartTime }
        'Days' { $triggers += New-ScheduledTaskTrigger -Daily -DaysInterval $Interval -At $StartTime }
        'Hours' {
            if ($Interval -gt 24) { throw 'Per lo scheduling orario, Interval deve essere compreso tra 1 e 24.' }
            $startAt = $StartTime
            if ($startAt -le (Get-Date)) { $startAt = $startAt.AddDays(1) }
            $triggers += New-ScheduledTaskTrigger -Once -At $startAt -RepetitionInterval (New-TimeSpan -Hours $Interval) -RepetitionDuration (New-TimeSpan -Days 3650)
        }
    }
    if ($AddStartupTrigger.IsPresent) { $triggers += New-ScheduledTaskTrigger -AtStartup }
    $principal = New-ScheduledTaskPrincipal -UserId 'SYSTEM' -LogonType ServiceAccount -RunLevel Highest
    $settings = New-ScheduledTaskSettingsSet -Hidden -StartWhenAvailable -AllowStartIfOnBatteries -DontStopIfGoingOnBatteries -MultipleInstances IgnoreNew
    $task = New-ScheduledTask -Action $action -Trigger $triggers -Principal $principal -Settings $settings -Description 'Pulizia automatica dei file temporanei di Windows.'
    Register-ScheduledTask -TaskName $TaskName -InputObject $task -Force | Out-Null
} catch { Write-Error $_.Exception.Message; exit 1 }
