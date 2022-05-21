using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_layer.Data
{
    public class DataStorageTemp
    {
        public List<GameIdea> GameIdeas { get; set; }
        private GameIdea gameIdeaTest = new GameIdea("test1");
        private GameIdea gameIdeaTest2 = new GameIdea("test2");

        public DataStorageTemp()
        {
            this.GameIdeas = new List<GameIdea>();
            this.GameIdeas.Add(gameIdeaTest);
            this.GameIdeas.Add(gameIdeaTest2);
        }

        public void AddGameIdea(GameIdea gameIdea) 
        {
            if(gameIdea != null)
            {
                this.GameIdeas.Add(gameIdea);
            }
            else { throw new Exception("Empty object exception!"); }
            
        }

        public List<GameIdea> GetGameIdeas()
        {
            return this.GameIdeas;
        }

        public GameIdea GetGameIdeaByName(string gameIdea)
        {
            return this.GameIdeas.FirstOrDefault(x => x.GameIdeaName == gameIdea);
        }

        public void DeleteGameIdeaByName(string gameIdeaName)
        {
            
        }


    }
}
