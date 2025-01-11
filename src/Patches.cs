// ReSharper disable UnusedType.Global

namespace Doorstop;

[Harmony]
public static class Patches
{
    [HarmonyPatch(typeof(AppDomain), nameof(Load))]
    [HarmonyPatch([typeof(byte[]), typeof(byte[]), typeof(System.Security.Policy.Evidence), typeof(bool)])]
    [HarmonyPrefix]
    public static void Load(ref byte[] rawAssembly, ref byte[] rawSymbolStore)
    {
        try
        {
            rawSymbolStore = Pdb2Mdb.Converter.Convert(rawAssembly, rawSymbolStore);
        }
        catch (Exception exception)
        {
            FileLog.Log($"Failed to load symbols for assembly: {exception}");
        }
    }
}