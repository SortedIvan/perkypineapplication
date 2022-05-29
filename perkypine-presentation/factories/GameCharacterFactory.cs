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

        #region Character creation based on game category
        public GameCharacter CreateSpaceCharacter()
        {
            string fullName = nameAlgorithm.SpaceCharacterNameGenerator();
            string characterHair = loreAlgorithm.HairBuilder();
            string characterJob = loreAlgorithm.CharacterSpaceJobBuilder();
            string characterTraits = loreAlgorithm.CharacteristicsBuilder();
            return new GameCharacter(fullName, $"{characterHair} {characterJob} {characterTraits}");
        }

        public GameCharacter CreateFantasyCharacter()
        {
            string fullName = nameAlgorithm.FantasyNameGenerator();
            string characterHair = loreAlgorithm.HairBuilder();
            string characterJob = loreAlgorithm.CharacterFantasyJobBuilder();
            string characterTraits = loreAlgorithm.CharacteristicsBuilder();
            return new GameCharacter(fullName, $"{characterHair} {characterJob} {characterTraits}");
        }

        public GameCharacter CreateSciFiCharacter()
        {
            string fullName = nameAlgorithm.SciFiNameGenerator();
            string characterHair = loreAlgorithm.HairBuilder();
            string characterJob = loreAlgorithm.CharacterScifiJobBuilder();
            string characterTraits = loreAlgorithm.CharacteristicsBuilder();
            return new GameCharacter(fullName, $"{characterHair} {characterJob} {characterTraits}");
        }
        #endregion
    }
}
