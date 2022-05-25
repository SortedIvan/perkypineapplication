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
            //var task = nameApi.TestApi();
            //task.Wait();
            //var jokeResult = task.Result.fact;
            //var result = Task.Run(async () => await apiConnector.GetCatFact()).Result.fact;
            Root result = Task.Run(async () => await apiConnector.GetRandomName(true, "male")).Result;
            return new GameIdea(gameIdeaName + result.results[0].name.first);
        }
    }
}
