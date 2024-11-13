# Elin Mod Template

Using this template:
- Rename `ExampleMod.csproj` -> `YourModName.csproj`
- Modify in `.csproj`
  - `<ModName>Mod_ExampleMod</ModName>` -> `Mod_YourModName`
- Modify in `Plugin.cs`
  - `[BepInPlugin("yourname.example.mod", "Example Mod", "1.0.0.0")]` to have a unique mod id, and an interesting title for your mod
  - `var harmony = new Harmony("yourname.example.mod");` with the same id.


----

LICENSE: This *template* is under MIT/APACHE (very permissive). Your code can be under whatever license you want, with the default being not thinking about it at all.