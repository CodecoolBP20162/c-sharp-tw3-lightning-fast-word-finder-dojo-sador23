using System;
using System.IO;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            string [] input = File.ReadAllText("history-of-egypt-chaldea-syria-babylonia-assyria.txt").Split();
            String longest = "";
           foreach(String word in input)
            {
                if (word.Length > longest.Length) longest = word; 
            }
            return longest;
        }
    }
}
