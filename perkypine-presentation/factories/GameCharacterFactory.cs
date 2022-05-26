using helper_classes;
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
        GameCharacterLoreAlgorithm loreAlgorithm;
        public GameCharacterFactory()
        {
            this.nameAlgorithm = new GameCharacterNameAlgorithm();
            this.loreAlgorithm = new GameCharacterLoreAlgorithm();
        }


        public GameCharacter CreateGameCharacter()
        {
            string fullName = $"{this.nameAlgorithm.FirstNameGenerator()} {this.nameAlgorithm.SecondNameGenerator()}";
            string characterLore = loreAlgorithm.HairBuilder();
            return new GameCharacter(fullName, characterLore);
        }
    }
}
