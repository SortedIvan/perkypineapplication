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

            hairStyle += $"They have {haircolors[randomHairColorInt]}, {hairstyles[randomHairStyleInt]} hairstyle";
            return hairStyle;
        }

        #region Character jobs builders
        public string CharacterSpaceJobBuilder()
        {
            Random randomSpaceJob = new Random();
            int randomSpaceJobInt = randomSpaceJob.Next(1, 19);

            return $"Their occupation is {this.fileReader.GetSpaceJobs()[randomSpaceJobInt]}.";
        }

        public string CharacterFantasyJobBuilder()
        {
            Random randomFantasyJob = new Random();
            int randomFantasyJobInt = randomFantasyJob.Next(1, 36);

            return $"Their occupation is {this.fileReader.GetFantasyJobs()[randomFantasyJobInt]}.";
        }

        public string CharacterScifiJobBuilder()
        {
            Random randomSciFiJob = new Random();
            int randomSciFiJobInt = randomSciFiJob.Next(1, 74);

            return $"Their occupation is {this.fileReader.GetScifiJobs()[randomSciFiJobInt]}.";
            #endregion
        }
    }
}
