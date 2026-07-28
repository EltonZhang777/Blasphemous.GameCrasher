using Blasphemous.ModdingAPI;

namespace Blasphemous.GameCrasher;

public class GameCrasher : BlasMod
{
    internal GameCrasher() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

    protected override void OnInitialize()
    {
        // Perform initialization here
    }
}
