using models;
using helper_classes;
using System.Net.Http;
using System.Threading.Tasks;

namespace factories
{
    public class GameIdeaFactory
    {
        private ClientFactory clientFactory;
        private ApiConnector apiConnector;
        public GameIdeaFactory()
        {
            this.clientFactory = new ClientFactory();
            this.apiConnector = new ApiConnector(clientFactory);
        }


        public GameIdea CreateGameIdea(string gameIdeaName)
        {
            return new GameIdea(gameIdeaName);
        }
    }
}
