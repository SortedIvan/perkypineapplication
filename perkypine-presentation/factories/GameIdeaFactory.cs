using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factories
{
    public class GameIdeaFactory
    {
        public GameIdeaFactory()
        {

        }

        public GameIdea CreateGameIdea(string gameIdeaName)
        {
            return new GameIdea(gameIdeaName);
        }
    }
}
