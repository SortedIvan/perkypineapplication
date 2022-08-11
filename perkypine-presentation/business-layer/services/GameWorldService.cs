using business_layer.interfaces;
using factories;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_layer.services
{
    public class GameWorldService : IGameWorldService
    {
        private GameWorldFactory gameWorldFactory;
        public GameWorldService()
        {
            this.gameWorldFactory = new GameWorldFactory();
        }

        public GameWorld GetGameWorld()
        {
            return this.gameWorldFactory.GetWorldForGame("basic genr");
        }
    }
}
