using System.Collections.Generic;
namespace models
{
    public class GameWorld
    {
        public string GameWorldName { get; set; }
        public GameWorld(string gameWorldName)
        {
            this.GameWorldName = gameWorldName;
        }

    }
}
