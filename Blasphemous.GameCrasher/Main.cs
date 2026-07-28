using BepInEx;

namespace Blasphemous.GameCrasher;

[BepInPlugin(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_VERSION)]
[BepInDependency("Blasphemous.ModdingAPI", "0.1.0")]
internal class Main : BaseUnityPlugin
{
    public static GameCrasher GameCrasher { get; private set; }

    private void Start()
    {
        GameCrasher = new GameCrasher();
    }
}
