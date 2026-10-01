using FrooxEngine;
using FrooxEngine.UIX;
using HarmonyLib;
using ResoniteModLoader;

namespace SpeedyURLs;

public sealed class SpeedyURLsMod : ResoniteMod
{
    public override string Name => "SpeedyURLs";
    public override string Author => "LeCloutPanda, dfgHiatus";
    public override string Version => "2.2.0";
    public override string Link => "https://github.com/LeCloutPanda/SpeedyURLs";

    public override void OnEngineInit()
    {
        new Harmony("dev.lecloutpanda.speedyurls").PatchAll();
    }

    [HarmonyPatch(typeof(UIExtensions), nameof(UIExtensions.EnableTimeout), new[]
    {
        typeof(Component),
        typeof(IField<bool>),
        typeof(IField<string>),
        typeof(int)
    })]
    private static class HyperlinkOpenDialogPatch
    {
        private static void Prefix(ref int timeout) => timeout = 0;
    }
}
