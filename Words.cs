using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wordUnscrambler
{
    internal class Words
    {
        public static List<String> MatchedWords(Array enteredWords)
        {
            var unscrambledWords = new List<String>();
            string[] fileContent = File.ReadAllLines("words.txt");
            //string[] fileContent = new string[3] { "rome", "beef", "land" };
            foreach (string line in fileContent)
            {
                foreach (string word in enteredWords)
                {
                    if(line.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        unscrambledWords.Add(line);
                    } else
                    {
                        Char[] wordArray = word.ToCharArray();
                        Char[] lineArray = line.ToCharArray();

                        Array.Sort(wordArray);
                        Array.Sort(lineArray);

                        string wordArrayString = new string(wordArray);
                        string lineArrayString = new string(lineArray);

                        if(wordArrayString.Equals(lineArrayString, StringComparison.OrdinalIgnoreCase))
                        {
                            unscrambledWords.Add(line);
                        }
                    }
                }
            }
            return unscrambledWords;
        }
    }
}
