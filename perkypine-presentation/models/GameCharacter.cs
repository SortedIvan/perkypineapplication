namespace models
{
    public class GameCharacter
    {
        public string CharacterName { get; set; }
        public string CharacterLore { get; set; }

        public GameCharacter(string characterName, string characterLore)
        {
            this.CharacterLore = characterLore;
            this.CharacterName = characterName;
        }
    }
}
