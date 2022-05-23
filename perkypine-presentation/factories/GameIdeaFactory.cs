using models;
namespace factories
{
    public class GameIdeaFactory
    {
        public GameIdeaFactory()
        {

        }

        public GameIdea CreateGameIdea(string gameIdeaName)
        {
            return new GameIdea(gameIdeaName);
        }
    }
}
