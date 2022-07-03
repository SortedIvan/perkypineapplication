using System;
using System.Collections.Generic;

namespace helper_classes.GameWorldHelper
{
    public class GameWorldNameHelper
    {
        private FileReader fileReader;
        public GameWorldNameHelper()
        {
            this.fileReader = new FileReader();
        }

        private List<int> RandomNumGens()
        {
            Random random = new Random(); // 42, 31
            Random random2 = new Random();

            int A = random.Next(1, 40);
            int B = random2.Next(1, 30);

            List<int> randomInts = new List<int>();
            randomInts.Add(A);
            randomInts.Add(B);

            return randomInts;
        }

        public string GetRandomWorldName()
        {
            string firstHalf = fileReader.GetWorldNameCharacteristicsA()[RandomNumGens()[0]];
            string secondHalf = fileReader.GetWorldNameCharacteristicsB()[RandomNumGens()[1]];
            return firstHalf + secondHalf;
        }

    }
}
