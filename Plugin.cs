using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace ExampleMod;

[BepInPlugin("yourname.example.mod", "Example Mod", "1.0.0.0")]
public class Plugin : BaseUnityPlugin
{
    private void Start()
    {
        System.Console.WriteLine("Hello World from Elin Example Mod!");
        var harmony = new Harmony("yourname.example.mod");
        harmony.PatchAll();
    }
    public void OnStartCore()
    {
        var dir = Path.GetDirectoryName(Info.Location);
        var excel = dir + "/SourceCard.xlsx";
        var sources = Core.Instance.sources;
        ModUtil.ImportExcel(excel, "Thing", sources.things);
    }
}
