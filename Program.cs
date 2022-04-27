using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wordUnscrambler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************** Welcome to the word unscrambler **************************************");
            bool next = true;
            do
            {
                Console.WriteLine("enter the team name from 5 great championship in europe to unscrambled and seperate them with a coma(;)");
                string words = Console.ReadLine();
                string[] arrayWords = words.Split(';');
                var unscrambledWordsList = Words.MatchedWords(arrayWords);
                foreach(string item in unscrambledWordsList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Would you like to continue ?? press (Y) for yes or (N) for No");
                string decision = Console.ReadLine();

                switch (decision)
                {
                    case "y":
                        next = true;
                        break;
                    case "n":
                        next = false;
                        break;
                    default:
                        break;
                }
            } while (next == true);
        }
    }
}
