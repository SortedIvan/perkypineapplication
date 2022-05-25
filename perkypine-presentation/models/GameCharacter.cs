using System;

namespace models
{
    public class GameCharacter
    {
        public string CharacterName { get; set; }
        public string CharacterLore { get; set; }
        public Guid GameIdeaID { get; set; }

        public GameCharacter(string characterName, string characterLore)
        {
            this.CharacterLore = characterLore;
            this.CharacterName = characterName;
        }

        public GameCharacter(Guid gameCharacterID, string characterName, string characterLore)
        {
            this.CharacterLore = characterLore;
            this.CharacterName = characterName;
            this.GameIdeaID = gameCharacterID;
        }
    }
}
