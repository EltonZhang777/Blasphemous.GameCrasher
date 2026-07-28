using Blasphemous.ModdingAPI;
using Blasphemous.ModdingAPI.Helpers;

namespace Blasphemous.GameCrasher;

/// <inheritdoc />
public class GameCrasher : BlasMod
{
    internal GameCrasher() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

    /// <inheritdoc />
    protected override void OnInitialize()
    {
        // Read target mods from config (auto-creates file on first run)
        Config config = ConfigHandler.Load<Config>();

        // Check if any target mod is loaded, crash game if yes
        foreach (string targetId in config.TargetMods)
        {
            if (ModHelper.IsModLoadedById(targetId))
            {
                ModLog.Error($"Detected loaded mod `{targetId}`, crashing game!");
                UnityEngine.Application.Quit();
            }
        }
    }
}
