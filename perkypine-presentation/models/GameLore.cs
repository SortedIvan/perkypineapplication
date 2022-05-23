namespace models
{
    public class GameLore
    {
        public string GameLoreDescription { get; set; }

        public GameLore(string gameLoreDescription)
        {
            this.GameLoreDescription = gameLoreDescription;
        }
    }
}
