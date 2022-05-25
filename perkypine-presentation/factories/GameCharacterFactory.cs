using helper_classes.GameCharacterHelper;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factories
{
    public class GameCharacterFactory
    {
        GameCharacterNameAlgorithm nameAlgorithm;
        public GameCharacterFactory()
        {
            this.nameAlgorithm = new GameCharacterNameAlgorithm();
        }

        public GameCharacter CreateGameCharacter()
        {
            string fullName = $"{this.nameAlgorithm.FirstNameGenerator()} {this.nameAlgorithm.SecondNameGenerator()}";
            return new GameCharacter("test", "test");
        }
    }
}
