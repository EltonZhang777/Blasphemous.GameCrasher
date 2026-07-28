using System.Collections.Generic;

namespace Blasphemous.GameCrasher;

internal class Config
{
    /// <summary>
    /// The list of mod IDs that, when detected, will crash the game
    /// </summary>
    public List<string> TargetMods { get; set; } = [];
}
