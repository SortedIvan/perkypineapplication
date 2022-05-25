using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helper_classes.GameCharacterHelper
{
    public class GameCharacterNameAlgorithm
    {
        private ClientFactory clientFactory;
        private ApiConnector apiConnector;
        public GameCharacterNameAlgorithm()
        {
            this.clientFactory = new ClientFactory();
            this.apiConnector = new ApiConnector(clientFactory);
        }

        public string FirstNameGenerator()
        {
            //result.results[0].name.first
            Root firstName = Task.Run(async () => await apiConnector.GetRandomName(true, "male")).Result;
            return firstName.results[0].name.first;
        }

        public string SecondNameGenerator()
        {
            //result.results[0].name.first
            Root secondName = Task.Run(async () => await apiConnector.GetRandomName(true, "male")).Result;
            return secondName.results[0].name.last;
        }
    }
}
