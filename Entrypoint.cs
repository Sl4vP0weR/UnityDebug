using System;
using System.Security.Policy;

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
    }
}
[Harmony]
public static class Patches
{
    [HarmonyPatch(typeof(AppDomain), nameof(Load), new[] { typeof(byte[]), typeof(byte[]), typeof(Evidence), typeof(bool) }), HarmonyPrefix]
    public static void Load(ref byte[] rawAssembly, ref byte[] rawSymbolStore)
    {
        try
        {
            rawSymbolStore = Pdb2Mdb.Converter.Convert(rawAssembly, rawSymbolStore);
        }
        catch { }
    }
}