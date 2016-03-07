# reference: http://www.codeproject.com/Tips/806257/Automating-NuGet-Package-Creation-using-AppVeyor

$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\Stone.Prepay.ApiClient\bin\Release\Stone.Prepay.ApiClient.dll").GetName().Version
$versionStr = "{0}.{1}.{2}" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\Stone.Prepay.ApiClient\Stone.Prepay.ApiClient.nuspec) 
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\Stone.Prepay.ApiClient.compiled.nuspec

& $root\.nuget\NuGet.exe pack $root\Stone.Prepay.ApiClient.compiled.nuspec -Prop Configuration=Release