os=$(uname)
os=$([[ "$os" == "Darwin" ]] && echo "MacOS" || echo "Linux")

arch=$(uname -m)
arch=$([[ "$arch" == *64* ]] && echo "x64" || echo "x86")

dotnet build src/UnityDebug.csproj -c $os -p:Platform=$arch