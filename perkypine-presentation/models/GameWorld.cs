using System.Collections.Generic;
namespace models
{
    public class GameWorld
    {
        public string GameWorldName { get; set; }
        public string GameWorldLore { get; set; }
        public GameWorld(string gameWorldName)
        {
            this.GameWorldName = gameWorldName;
            
        }
        public GameWorld(string gameWorldName, string gameWorldLore)
        {
            this.GameWorldName = gameWorldName;
            this.GameWorldLore = gameWorldLore;
        }
    }
}
