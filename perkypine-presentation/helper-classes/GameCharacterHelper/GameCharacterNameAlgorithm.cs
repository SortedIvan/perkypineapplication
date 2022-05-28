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

        #region Character name generators based on gender
        public string SpaceCharacterNameGenerator()
        {
            Random random = new Random();
            int maleOrfemale = random.Next(1, 4);
            if (maleOrfemale == 1 || maleOrfemale == 3)
            {
                Root spaceCharacterNameMale = Task.Run(async () => await apiConnector.GetRandomSpaceName("male")).Result;
                return $"{spaceCharacterNameMale.results[0].name.first} {spaceCharacterNameMale.results[0].name.last}";
            }
            else if (maleOrfemale == 2 || maleOrfemale == 4)
            {
                Root spaceCharacterNameFemale = Task.Run(async () => await apiConnector.GetRandomSpaceName("female")).Result;
                return $"{spaceCharacterNameFemale.results[0].name.first} {spaceCharacterNameFemale.results[0].name.last}";
            }
            return null;

        }

        public string FantasyNameGenerator()
        {
            Random random = new Random();
            int maleOrfemale = random.Next(1, 4);
            if (maleOrfemale == 1 || maleOrfemale == 3)
            {
                Root fantasyCharacterNameMale = Task.Run(async () => await apiConnector.GetRandomFantasyName("male")).Result;
                return $"{fantasyCharacterNameMale.results[0].name.first} {fantasyCharacterNameMale.results[0].name.last}";
            }
            else if (maleOrfemale == 2 || maleOrfemale == 4)
            {
                Root fantasyCharacterNameFemale = Task.Run(async () => await apiConnector.GetRandomFantasyName("female")).Result;
                return $"{fantasyCharacterNameFemale.results[0].name.first} {fantasyCharacterNameFemale.results[0].name.last}";
            }
            return null;

        }

        public string SciFiNameGenerator()
        {
            Random random = new Random();
            int maleOrfemale = random.Next(1, 4);
            if (maleOrfemale == 1 || maleOrfemale == 3)
            {
                Root scifiCharacterNameMale = Task.Run(async () => await apiConnector.GetRandomSciFiName("male")).Result;
                return $"{scifiCharacterNameMale.results[0].name.first} {scifiCharacterNameMale.results[0].name.last}";
            }
            else if (maleOrfemale == 2 || maleOrfemale == 4)
            {
                Root scifiCharacterNameFemale = Task.Run(async () => await apiConnector.GetRandomSciFiName("female")).Result;
                return $"{scifiCharacterNameFemale.results[0].name.first} {scifiCharacterNameFemale.results[0].name.last}";
            }
            return null;

        }
        #endregion
    }
}
