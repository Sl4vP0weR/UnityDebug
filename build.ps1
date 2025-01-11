$arch = (Get-CimInstance -ClassName Win32_OperatingSystem).OSArchitecture
if ($arch -match "64") {
    $arch = "x64"
} else {
    $arch = "x86"
}

dotnet build src/UnityDebug.csproj -c Win -p:Platform=$arch