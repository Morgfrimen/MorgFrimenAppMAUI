Param (
[string]$FirstFolder,
[string]$SecondFolder
)

Copy-Item -Path $FirstFolder -Destination $SecondFolder -Recurse