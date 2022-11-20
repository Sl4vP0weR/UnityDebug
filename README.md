# UnityDebug
UnityDoorstep implementation with Harmony patch that converts pdb to mdb allowing mono to read debug symbols.

### Prerequisites:

- [.NET SDK 6+](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [.NET 4.8 Runtime + SDK](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)

### How to build:

1. Select your configuration(Win/MacOS/Linux).
2. Select your platform(x64/x86) or AnyCPU if you already installed UnityDoorstep.
3. Build project.
4. Copy contents of (Project Directory)/build/(Configuration)_(Platform)/ to the root of the game.

### How to use:
1. Attach debugger to the port 56000(default port) in your IDE(Visual Studio/Rider)/Decompiler(dnSpy).
2. Set breakpoint whenever you want in the code and do something or wait until game stops on this breakpoint.
