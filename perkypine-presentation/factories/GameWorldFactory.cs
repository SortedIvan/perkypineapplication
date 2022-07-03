using helper_classes.GameWorldHelper;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factories
{
    public class GameWorldFactory
    {
        private GameWorldNameHelper nameHelper;
        public GameWorldFactory()
        {
            this.nameHelper = new GameWorldNameHelper();
        }

        public GameWorld GetWorldForGame(string gameGenre)
        {
            GameWorld gameWorld = new GameWorld(this.nameHelper.GetRandomWorldName());
            return gameWorld;
        }

    }
}
