using System.Collections.Generic;
namespace models
{
    public class GameWorld
    {
        public string GameWorldName { get; set; }
        public List<string> GameWorldRegions
        { get; set; }
        public GameWorld(string gameWorldName, List<string> GameWorldRegions)
        {
            this.GameWorldName = gameWorldName;
            this.GameWorldRegions = GameWorldRegions;
        }

    }
}
