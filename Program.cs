using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gamemode="", word;
            bool valid = false;
            Console.WriteLine("1: Easy Mode");
            Console.WriteLine("2: Medium Mode");
            Console.WriteLine("3: Hard Mode");
            Console.WriteLine("4: Custom");
            while (gamemode == "")
            {
                gamemode=Console.ReadLine();
                if (gamemode == "1")
                {

                }
                else if (gamemode == "2")
                {

                }
                else if (gamemode == "3")
                {

                }
                else if (gamemode == "4")
                {
                    Console.Write("Enter Secret Word: ");
                    while (!valid)
                    {
                        word = Console.ReadLine().ToUpper();
                        if (Regex.IsMatch(word, @"^[a-zA-Z]+$"))
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Word");
                        }
                    }
                }
                else
                {
                    gamemode = "";
                    Console.WriteLine("Invalid Input");
                }
            }
            Console.ReadLine();
        }
    }
}
