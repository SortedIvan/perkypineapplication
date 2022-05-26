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

            hairStyle += $"They have {haircolors[randomHairColorInt]}, {hairstyles[randomHairStyleInt]}";
            return hairStyle;
        }

    }
}
