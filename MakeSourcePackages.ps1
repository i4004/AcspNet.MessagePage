# Getting packages versions

$version = [System.Diagnostics.FileVersionInfo]::GetVersionInfo("$PSScriptRoot/AcspNet.MessagePage/bin/Release/AcspNet.MessagePage.dll").FileVersion

# Packing source packages

.nuget\NuGet.exe pack AcspNet.MessagePage/AcspNet.MessagePage.Sources.nuspec -Version $version

# Publishing to Appveyor artifacts

Get-ChildItem .\*.nupkg | % { Push-AppveyorArtifact $_.FullName -FileName $_.Name }
