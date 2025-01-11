// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace Doorstop;

public static class Entrypoint
{
    public static Harmony Harmony;
    public static void Start()
    {
#if DEBUG
            Harmony.DEBUG = true;
#endif
        Harmony = new Harmony(nameof(Doorstop));
        Harmony.PatchAll();
    }
}