using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helper_classes
{
    public class FileReader
    {
        public FileReader()
        {

        }

        // Methods that return different hairstyles
        #region Hairstyle methods
        public string[] GetHairStyles()
        {
            string[] hairstyles = System.IO.File.ReadAllLines(@"C:\PerkyPine\perkypineapplication\perkypine-presentation\helper-classes\FileStorage\hair.txt");
            return hairstyles;
        }

        public string[] GetHairColor()
        {
            string[] haircolors = System.IO.File.ReadAllLines(@"C:\PerkyPine\perkypineapplication\perkypine-presentation\helper-classes\FileStorage\haircolor.txt");
            return haircolors;
        }
        #endregion

        // Methods that return different character jobs based on category
        #region Character jobs region
        public string[] GetSpaceJobs()
        {
            string[] spacejobs = System.IO.File.ReadAllLines(@"C:\PerkyPine\perkypineapplication\perkypine-presentation\helper-classes\CharacterLores\spacetheme.txt");
            return spacejobs;
        }

        public string[] GetScifiJobs()
        {
            string[] scifijobs = System.IO.File.ReadAllLines(@"C:\PerkyPine\perkypineapplication\perkypine-presentation\helper-classes\CharacterLores\scifi.txt");
            return scifijobs;
        }

        public string[] GetFantasyJobs()
        {
            string[] fantasyjobs = System.IO.File.ReadAllLines(@"C:\PerkyPine\perkypineapplication\perkypine-presentation\helper-classes\CharacterLores\fantasy.txt");
            return fantasyjobs;
        }
        #endregion

        #region Character characteristics region
        public string[] GetGeneralCharacterTraits()
        {
            string[] generaltraits = System.IO.File.ReadAllLines(@"C:\PerkyPine\perkypineapplication\perkypine-presentation\helper-classes\GameCharacterStorage\generalcharacteristics.txt");
            return generaltraits;
        }

        public string[] GetGeneralCharacterTraitsKeySentences()
        {
            string[] keysentences = System.IO.File.ReadAllLines(@"C:\PerkyPine\perkypineapplication\perkypine-presentation\helper-classes\GameCharacterStorage\keysentencescharacter1.txt");
            return keysentences;
        }

        #endregion
    }
}
