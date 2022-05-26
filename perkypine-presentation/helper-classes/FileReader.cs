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
    }
}
