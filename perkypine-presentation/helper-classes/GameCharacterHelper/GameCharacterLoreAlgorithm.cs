using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helper_classes.GameCharacterHelper
{
    public class GameCharacterLoreAlgorithm
    {
        private FileReader fileReader;
        private static string characterOccupationPreset = "Their occupation is: ";
        public GameCharacterLoreAlgorithm()
        {
            this.fileReader = new FileReader();
        }

        public string HairBuilder()
        {
            Random randomHairStyle = new Random();
            Random randomHairColor = new Random();

            int randomHairColorInt = randomHairColor.Next(2, 40);
            int randomHairStyleInt = randomHairStyle.Next(2, 90);

            string hairStyle = "";
            string[] hairstyles = this.fileReader.GetHairStyles();
            string[] haircolors = this.fileReader.GetHairColor();

            hairStyle += $"Type of hair: {haircolors[randomHairColorInt]}, {hairstyles[randomHairStyleInt]} hairstyle.";
            return hairStyle;
        }

        #region Character jobs builders
        public string CharacterSpaceJobBuilder()
        {
            Random randomSpaceJob = new Random();
            int randomSpaceJobInt = randomSpaceJob.Next(1, 19);

            return $"{characterOccupationPreset} {this.fileReader.GetSpaceJobs()[randomSpaceJobInt]}.";
        }

        public string CharacterFantasyJobBuilder()
        {
            Random randomFantasyJob = new Random();
            int randomFantasyJobInt = randomFantasyJob.Next(1, 70);

            return $"{characterOccupationPreset} {this.fileReader.GetFantasyJobs()[randomFantasyJobInt]}.";
        }

        public string CharacterScifiJobBuilder()
        {
            Random randomSciFiJob = new Random();
            int randomSciFiJobInt = randomSciFiJob.Next(1, 74);

            return $"{characterOccupationPreset} {this.fileReader.GetScifiJobs()[randomSciFiJobInt]}.";
            
        }
        #endregion

        #region Character characteristics generators
        public string CharacteristicsBuilder()
        {
            Random randomCharacteristicTrait = new Random();
            Random randomKeySentence = new Random();

            int randomCharacteristicTraitInt1 = randomCharacteristicTrait.Next(1, 146);
            int randomCharacteristicTrainInt2 = randomCharacteristicTrait.Next(1, 146);
            int randomKeySentenceInt = randomKeySentence.Next(1, 5);

            while(randomCharacteristicTraitInt1 == randomCharacteristicTrainInt2)
            {
                randomCharacteristicTraitInt1 = randomCharacteristicTrait.Next(1, 146);
            }

            return $"{this.fileReader.GetGeneralCharacterTraitsKeySentences()[randomKeySentenceInt]} " +
                $"{this.fileReader.GetGeneralCharacterTraits()[randomCharacteristicTraitInt1]} and " +
                $"{this.fileReader.GetGeneralCharacterTraits()[randomCharacteristicTrainInt2]} are predominant about them.";
        }


        #endregion
    }
}
