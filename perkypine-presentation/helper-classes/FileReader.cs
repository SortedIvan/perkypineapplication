using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helper_classes
{
    public class FileReader
    {
        private static string hairstylesFile = "hair.txt";
        private static string haircolorsFile = "haircolor.txt";
        private static string spacejobsFile = "spacetheme.txt";
        private static string scifijobsFIle = "scifi.txt";
        private static string fantasyjobsFile = "fantasy.txt";
        private static string generaltraitsFile = "generalcharacteristics.txt";
        private static string keysentencesFile = "keysentencescharacter1.txt";

        string hairstylesFilePath = Path.Combine(Environment.CurrentDirectory, @"FileStorage\", hairstylesFile);
        string haircolorsFilePath = Path.Combine(Environment.CurrentDirectory, @"FileStorage\", haircolorsFile);
        string spacejobsFilePath = Path.Combine(Environment.CurrentDirectory, @"CharacterLores\", spacejobsFile);
        string scifijobsFilePath = Path.Combine(Environment.CurrentDirectory, @"CharacterLores\", scifijobsFIle);
        string fantasyjobsFilePath = Path.Combine(Environment.CurrentDirectory, @"CharacterLores\", fantasyjobsFile);
        string generaltraitsFilePath = Path.Combine(Environment.CurrentDirectory, @"GameCharacterStorage\", generaltraitsFile);
        string keysentencesFilePath = Path.Combine(Environment.CurrentDirectory, @"GameCharacterStorage\", keysentencesFile);

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
