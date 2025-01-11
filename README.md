# UnityDebug
UnityDoorstop implementation with Harmony patch that converts .pdb to .mdb, allowing mono to read debug symbols.

This theoretically is applied to almost any Unity version. Manually tested and developed for 2020-2021 Unity versions.

## Prerequisites:

- [Latest or LTS .NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/)

## How to build:

### In terminal:

1. Run `./build.ps1` on Windows or `./build.sh` on Linux/MacOS.

### Manually in IDE:

1. Open solution `UnityDebug.sln`.
2. Select your configuration(Win/MacOS/Linux).
3. Select your platform(x64/x86) or AnyCPU if you already installed UnityDoorstop.
4. Build project.

## How to use:
1. Copy contents of (Project Directory)/build/(Configuration)_(Platform)/ to the root of the game.
2. Set breakpoint wherever you want in the code in your IDE(Visual Studio/JetBrains Rider/VS Code) or Decompiler(dnSpy).
3. Start the game.
4. Attach debugger to the port 56000(default port).
5. Wait or interact with the game until it steps on the breakpoint.