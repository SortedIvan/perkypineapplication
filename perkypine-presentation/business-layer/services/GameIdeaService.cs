using System;
using System.Collections.Generic;
using business_layer.interfaces;
using data_layer.Data;
using factories;
using models;
using System.Linq;

namespace business_layer.services
{
    public class GameIdeaService : IGameIdeaService
    {
        private GameIdeaFactory gameIdeaFactory;
        private DataStorageTemp dataStorage;
        private DatabaseFactory DBFactory;
        private PerkyPineDB DB;
        public GameIdeaService()
        {
            this.gameIdeaFactory = new GameIdeaFactory();
            this.dataStorage = new DataStorageTemp();
            this.DBFactory = new DatabaseFactory();
            this.DB = DBFactory.CreateDB();

        }

        public void CreateAndSaveGameIdea(string gameName)
        {
            this.dataStorage.AddGameIdea(this.gameIdeaFactory.CreateGameIdea(gameName));
        }

        public bool DeleteGameByID(Guid gameID)
        {
            if(GetGameIdeaById(gameID) != null)
            {
                this.dataStorage.GameIdeas.Remove(
                dataStorage.GameIdeas.FirstOrDefault(gameIdeaToRemove => gameIdeaToRemove.GameIdeaID == gameID));
                return true;
            }
            return false;

        }

        public void TestMethod(Guid guid)
        {
            this.dataStorage.GetGameIdeaById(guid).GameCharacters.Add(new GameCharacter("hi", "hi"));
        }

        public void DeleteGameIdeaByID(Guid gameID)
        {
            this.dataStorage.GameIdeas.Remove(
            this.dataStorage.GetGameIdeaById(gameID));
        }

        public void EditGameIdeaByGameID(Guid gameID, string newGameIdeaName)
        {
            this.dataStorage.GetGameIdeaById(gameID).GameIdeaName = newGameIdeaName;
        }

        public GameIdea GetGameIdeaById(Guid gameIdeaId)
        {
            return this.dataStorage.GetGameIdeaById(gameIdeaId);
        }

        public GameIdea GetGameIdeaByName(string gameIdea)
        {
            return dataStorage.GetGameIdeaByName(gameIdea);
        }

        public List<GameIdea> GetGameIdeas()
        {
            return dataStorage.GetGameIdeas();
        }

        public GameIdea TestDatabase(Guid gameIdeaID)
        {
            return DB.GetGameIdea(gameIdeaID);
        }

        public GameIdea CreateReturnableGameIdea(string gameIdeaName)
        {
            return gameIdeaFactory.CreateGameIdea(gameIdeaName);
        }
    }
}
