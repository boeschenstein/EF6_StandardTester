# https://blogs.msdn.microsoft.com/rbrundritt/2014/09/18/cleaning-up-visual-studio-project-folders-using-powershell/

$slnFileToCheck = ".\EF6_StandardTester.sln"
if ((Test-Path $slnFileToCheck -PathType leaf))
{
    "Solution file found. Current directory:"
    (Get-Item -Path ".\").FullName
} else {
    "Check start directory! Current directory:"
    (Get-Item -Path ".\").FullName
    throw "Solution file not found in current directory"
}

'========================== BEFORE ========================== '

Get-ChildItem .\ -include packages,bin,obj,bld,Backup,_UpgradeReport_Files,Debug,Release,ipch,help -Recurse 

'========================== DELETING NOW ==================== '

Get-ChildItem .\ -include packages,bin,obj,bld,Backup,_UpgradeReport_Files,Debug,Release,ipch,help -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse }

'========================== AFTER =========================== '

Get-ChildItem .\ -include packages,bin,obj,bld,Backup,_UpgradeReport_Files,Debug,Release,ipch,help -Recurse 
