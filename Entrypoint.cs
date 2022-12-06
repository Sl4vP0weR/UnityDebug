namespace Doorstop;

public static class Entrypoint
{
    public static Harmony Harmony;
    public static void Start()
    {
#if DEBUG
        Harmony.DEBUG = true;
#endif
        Harmony = new(nameof(Doorstop));
        Harmony.PatchAll();
        HotReloader.Initialize();
    }
}