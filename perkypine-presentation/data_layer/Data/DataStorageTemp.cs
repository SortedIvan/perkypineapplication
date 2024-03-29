﻿using models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace data_layer.Data
{
    public class DataStorageTemp
    {
        public List<GameIdea> GameIdeas { get; set; }
        private GameIdea gameIdeaTest = new GameIdea("test1");
        private GameIdea gameIdeaTest2 = new GameIdea("test2");

        private GameCharacter gameChar1 = new GameCharacter("Tony", "Cool dude");


        public DataStorageTemp()
        {
            this.GameIdeas = new List<GameIdea>();
            gameIdeaTest.GameCharacters.Add(gameChar1);
            this.GameIdeas.Add(gameIdeaTest);
            this.GameIdeas.Add(gameIdeaTest2);
        }

        public void AddGameIdea(GameIdea gameIdea)
        {
            if (gameIdea != null)
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

        public GameIdea GetGameIdeaById(Guid gameIdea)
        {
            return this.GameIdeas.FirstOrDefault(x => x.GameIdeaID == gameIdea);
        }





    }
}
