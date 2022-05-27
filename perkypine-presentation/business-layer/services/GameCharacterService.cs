using business_layer.interfaces;
using data_layer.Data;
using factories;
using models;
using System;
using System.Collections.Generic;

namespace business_layer.services
{
    public class GameCharacterService : IGameCharacterService
    {
        private DataStorageTemp dataStorage;
        private GameCharacterFactory gameCharacterFactory;
        public GameCharacterService()
        {
            //Possible flaw => this object is initialized in two places (GameIdeaService)
            this.dataStorage = new DataStorageTemp();
            this.gameCharacterFactory = new GameCharacterFactory();
        }

        public void CreateAndSaveGameCharacterToGame(Guid gameID)
        {
            //Method that gets the game by its ID and creates and adds a game character object
            //using the game character factory pattern
            this.dataStorage.GetGameIdeaById(gameID).GameCharacters.Add(
                this.gameCharacterFactory.CreateGameCharacter());
        }

        public GameCharacter GetGameCharacter()
        {
            throw new NotImplementedException();
        }

        public List<GameCharacter> GetGameCharacters()
        {
            throw new NotImplementedException();
        }

        public List<GameCharacter> CreateAndReturnAddableCharacters()
        {
            List<GameCharacter> gameCharactersToReturn = new List<GameCharacter>();
            gameCharactersToReturn.Add(this.gameCharacterFactory.CreateGameCharacter());
            gameCharactersToReturn.Add(this.gameCharacterFactory.CreateGameCharacter());
            gameCharactersToReturn.Add(this.gameCharacterFactory.CreateGameCharacter());
            return gameCharactersToReturn;
        }


    }
}
