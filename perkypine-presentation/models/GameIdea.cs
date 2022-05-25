using System;
using System.Collections.Generic;

namespace models
{
    public class GameIdea
    {
        public Guid GameIdeaID { get; set; }
        public string GameIdeaName { get; set; }
        
        //public GameWorld GameWorld { get; set; }
        //public GameLore GameLore { get; set; }
        public List<GameCharacter> GameCharacters { get; set; }
        

        public GameIdea(string gameName)
        {
            this.GameIdeaID = Guid.NewGuid();
            this.GameIdeaName = gameName;
            this.GameCharacters = new List<GameCharacter>();
        }

        public GameIdea(Guid gameIdeaID, string gameName, List<GameCharacter> gameCharacters)
        {
            this.GameIdeaID = gameIdeaID;
            this.GameIdeaName = gameName;
            this.GameCharacters = gameCharacters;
        }

        public override string ToString()
        {
            return $"GameName: {this.GameIdeaName}";
        }
    }
}
