using HarmonyLib;

// ReSharper disable once CheckNamespace
// ReSharper disable once UnusedType.Global
public static class SubverterPatch
{
    public static string Name = "Example.Subverter.Simple.Command";
    public static string Description = "Example patch with one command: cathello";
    public static Harmony Harm = new("org.ValidHunter.Example.Subverter.Simple.Command");
}