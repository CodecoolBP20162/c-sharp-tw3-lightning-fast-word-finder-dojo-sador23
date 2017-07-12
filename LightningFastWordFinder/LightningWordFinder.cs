using System;
using System.IO;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            bool isSymbol;
            string [] input = File.ReadAllText("history-of-egypt-chaldea-syria-babylonia-assyria.txt").Split(' ');
            String longest = "";
           foreach(String word in input)
            {
                isSymbol = false;
                foreach (Char c in word)
                {
                    if (Char.IsSymbol(c))
                    {
                        isSymbol = true;
                        break;
                    }
                }
                if (!isSymbol)
                {
                    if (word.Length > longest.Length) longest = word;
                }
                


            }
            return longest;
        }
    }
}
