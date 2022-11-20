using System;
using System.Security.Policy;

namespace Doorstop;

[Harmony]
public static partial class Patches
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