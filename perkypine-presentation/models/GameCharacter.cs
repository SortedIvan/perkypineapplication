namespace models
{
    public class GameCharacter
    {
        public string CharacterName { get; set; }
        public string CharacterType { get; set; }

        public GameCharacter(string characterName, string characterType)
        {
            this.CharacterType = characterType;
            this.CharacterName = characterName;
        }
    }
}
