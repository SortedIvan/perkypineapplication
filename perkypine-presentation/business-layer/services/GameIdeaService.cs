using System.Collections.Generic;
using business_layer.interfaces;
using data_layer.Data;
using factories;
using models;

namespace business_layer.services
{
    public class GameIdeaService : IGameIdeaService
    {
        private GameIdeaFactory gameIdeaFactory;
        private DataStorageTemp dataStorage;

        public GameIdeaService()
        {
            this.gameIdeaFactory = new GameIdeaFactory();
            this.dataStorage = new DataStorageTemp();
        }

        public void CreateAndSaveGameIdea(string gameName)
        {
            this.dataStorage.AddGameIdea(this.gameIdeaFactory.CreateGameIdea(gameName));
        }

        public void DeleteGameIdeaByName(string gameIdeaName)
        {
            this.dataStorage.GameIdeas.Remove(
            this.dataStorage.GetGameIdeaByName(gameIdeaName));
        }

        public void EditGameIdeaByName(string gameIdeaName, string newGameIdeaName)
        {
            this.dataStorage.GetGameIdeaByName(gameIdeaName).GameIdeaName = newGameIdeaName;
        }

        public GameIdea GetGameIdeaByName(string gameIdea)
        {
            return dataStorage.GetGameIdeaByName(gameIdea);
        }

        public List<GameIdea> GetGameIdeas()
        {
            return dataStorage.GetGameIdeas();
        }

    }
}
