using System;
using System.Collections.Generic;
using System.Data;
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
            string gamemode, word="", playAgain, progress="", guessString;
            bool valid, gameover;
            int incorrect, indexReplace;
            char guess='a';
            List <char> letters = new List <char> ();
            while (true)
            {
                Console.Clear();
                Word newword = new Word();
                gamemode = "";
                gameover = false;
                valid = false;
                incorrect = 0;
                Console.WriteLine("1: Easy Mode");
                Console.WriteLine("2: Medium Mode");
                Console.WriteLine("3: Hard Mode");
                Console.WriteLine("4: Custom");
                while (gamemode == "")
                {
                    gamemode = Console.ReadLine();
                    if (gamemode == "1")
                    {
                        newword.Easy();
                        word = newword.TheWord;
                    }
                    else if (gamemode == "2")
                    {
                        newword.Medium();
                        word = newword.TheWord;
                    }
                    else if (gamemode == "3")
                    {
                        newword.Hard();
                        word = newword.TheWord;
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
                progress = "";
                letters.Clear();
                for (int i = 0; i < word.Length; i++)
                {
                    progress = progress + " _ ";
                }
                while (!gameover)
                {
                    Console.Clear();
                    if (incorrect == 0)
                    {
                        Console.WriteLine("  +---+");
                        Console.WriteLine("  |   |");
                        Console.WriteLine("      |");
                        Console.WriteLine("      |");
                        Console.WriteLine("      |");
                        Console.WriteLine("      |");
                        Console.WriteLine("=========");
                        Console.WriteLine();
                        Console.WriteLine(progress);
                        Console.WriteLine();
                        Console.Write("Guess a Letter: ");
                        valid = false;
                        while (!valid)
                        {
                            guessString = Console.ReadLine().ToUpper();
                            if (char.TryParse(guessString, out guess) && Regex.IsMatch(guessString, @"^[a-zA-Z]+$")&& !letters.Contains(guess))
                            {
                                valid = true;
                                letters.Add(guess);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Guess");
                            }
                        }
                        if (word.Contains(guess))
                        {
                            indexReplace = 0;
                            foreach (char c in word)
                            {
                                if (c == guess)
                                {
                                    indexReplace=(word.IndexOf(c, indexReplace))*3+1;
                                    progress=progress.Remove(indexReplace, 1).Insert(indexReplace, Convert.ToString(guess));
                                }
                            }
                        }
                        else
                        {
                            incorrect++;
                        }
                        if (!progress.Contains("_"))
                        {
                            Console.Clear();
                            Console.WriteLine("YOU WIN!!!");
                            valid = false;
                            while (!valid)
                            {
                                Console.WriteLine("Play Again? (y/n)");
                                playAgain = Console.ReadLine().ToLower();
                                if (playAgain == "y")
                                {
                                    valid = true;
                                    gameover = true;
                                }
                                else if (playAgain == "n")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Play Again? (y/n)");
                                }
                            }
                        }
                    }
                    else if (incorrect == 1)
                    {
                        Console.WriteLine("  +---+");
                        Console.WriteLine("  |   |");
                        Console.WriteLine("  O   |");
                        Console.WriteLine("      |");
                        Console.WriteLine("      |");
                        Console.WriteLine("      |");
                        Console.WriteLine("=========");
                        Console.WriteLine(progress);
                        Console.WriteLine();
                        Console.Write("Guess a Letter: ");
                        valid = false;
                        while (!valid)
                        {
                            guessString = Console.ReadLine().ToUpper();
                            if (char.TryParse(guessString, out guess) && Regex.IsMatch(guessString, @"^[a-zA-Z]+$") && !letters.Contains(guess))
                            {
                                valid = true;
                                letters.Add(guess);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Guess");
                            }
                        }
                        if (word.Contains(guess))
                        {
                            indexReplace = 0;
                            foreach (char c in word)
                            {
                                if (c == guess)
                                {
                                    indexReplace = (word.IndexOf(c, indexReplace)) * 3 + 1;
                                    progress = progress.Remove(indexReplace, 1).Insert(indexReplace, Convert.ToString(guess));
                                }
                            }
                        }
                        else
                        {
                            incorrect++;
                        }
                        if (!progress.Contains("_"))
                        {
                            Console.Clear();
                            Console.WriteLine("YOU WIN!!!");
                            valid = false;
                            while (!valid)
                            {
                                Console.WriteLine("Play Again? (y/n)");
                                playAgain = Console.ReadLine().ToLower();
                                if (playAgain == "y")
                                {
                                    valid = true;
                                    gameover = true;
                                }
                                else if (playAgain == "n")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Play Again? (y/n)");
                                }
                            }
                        }
                    }
                    else if (incorrect == 2)
                    {
                        Console.WriteLine("  +---+");
                        Console.WriteLine("  |   |");
                        Console.WriteLine("  O   |");
                        Console.WriteLine("  |   |");
                        Console.WriteLine("      |");
                        Console.WriteLine("      |");
                        Console.WriteLine("=========");
                        Console.WriteLine(progress);
                        Console.WriteLine();
                        Console.Write("Guess a Letter: ");
                        valid = false;
                        while (!valid)
                        {
                            guessString = Console.ReadLine().ToUpper();
                            if (char.TryParse(guessString, out guess) && Regex.IsMatch(guessString, @"^[a-zA-Z]+$") && !letters.Contains(guess))
                            {
                                valid = true;
                                letters.Add(guess);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Guess");
                            }
                        }
                        if (word.Contains(guess))
                        {
                            indexReplace = 0;
                            foreach (char c in word)
                            {
                                if (c == guess)
                                {
                                    indexReplace = (word.IndexOf(c, indexReplace)) * 3 + 1;
                                    progress = progress.Remove(indexReplace, 1).Insert(indexReplace, Convert.ToString(guess));
                                }
                            }
                        }
                        else
                        {
                            incorrect++;
                        }
                        if (!progress.Contains("_"))
                        {
                            Console.Clear();
                            Console.WriteLine("YOU WIN!!!");
                            valid = false;
                            while (!valid)
                            {
                                Console.WriteLine("Play Again? (y/n)");
                                playAgain = Console.ReadLine().ToLower();
                                if (playAgain == "y")
                                {
                                    valid = true;
                                    gameover = true;
                                }
                                else if (playAgain == "n")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Play Again? (y/n)");
                                }
                            }
                        }
                    }
                    else if (incorrect == 3)
                    {
                        Console.WriteLine("  +---+");
                        Console.WriteLine("  |   |");
                        Console.WriteLine("  O   |");
                        Console.WriteLine(" /|   |");
                        Console.WriteLine("      |");
                        Console.WriteLine("      |");
                        Console.WriteLine("=========");
                        Console.WriteLine(progress);
                        Console.WriteLine();
                        Console.Write("Guess a Letter: ");
                        valid = false;
                        while (!valid)
                        {
                            guessString = Console.ReadLine().ToUpper();
                            if (char.TryParse(guessString, out guess) && Regex.IsMatch(guessString, @"^[a-zA-Z]+$") && !letters.Contains(guess))
                            {
                                valid = true;
                                letters.Add(guess);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Guess");
                            }
                        }
                        if (word.Contains(guess))
                        {
                            indexReplace = 0;
                            foreach (char c in word)
                            {
                                if (c == guess)
                                {
                                    indexReplace = (word.IndexOf(c, indexReplace)) * 3 + 1;
                                    progress = progress.Remove(indexReplace, 1).Insert(indexReplace, Convert.ToString(guess));
                                }
                            }
                        }
                        else
                        {
                            incorrect++;
                        }
                        if (!progress.Contains("_"))
                        {
                            Console.Clear();
                            Console.WriteLine("YOU WIN!!!");
                            valid = false;
                            while (!valid)
                            {
                                Console.WriteLine("Play Again? (y/n)");
                                playAgain = Console.ReadLine().ToLower();
                                if (playAgain == "y")
                                {
                                    valid = true;
                                    gameover = true;
                                }
                                else if (playAgain == "n")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Play Again? (y/n)");
                                }
                            }
                        }
                    }
                    else if (incorrect == 4)
                    {
                        Console.WriteLine("  +---+");
                        Console.WriteLine("  |   |");
                        Console.WriteLine("  O   |");
                        Console.WriteLine(" /|\\  |");
                        Console.WriteLine("      |");
                        Console.WriteLine("      |");
                        Console.WriteLine("=========");
                        Console.WriteLine(progress);
                        Console.WriteLine();
                        Console.Write("Guess a Letter: ");
                        valid = false;
                        while (!valid)
                        {
                            guessString = Console.ReadLine().ToUpper();
                            if (char.TryParse(guessString, out guess) && Regex.IsMatch(guessString, @"^[a-zA-Z]+$") && !letters.Contains(guess))
                            {
                                valid = true;
                                letters.Add(guess);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Guess");
                            }
                        }
                        if (word.Contains(guess))
                        {
                            indexReplace = 0;
                            foreach (char c in word)
                            {
                                if (c == guess)
                                {
                                    indexReplace = (word.IndexOf(c, indexReplace)) * 3 + 1;
                                    progress = progress.Remove(indexReplace, 1).Insert(indexReplace, Convert.ToString(guess));
                                }
                            }
                        }
                        else
                        {
                            incorrect++;
                        }
                        if (!progress.Contains("_"))
                        {
                            Console.Clear();
                            Console.WriteLine("YOU WIN!!!");
                            valid = false;
                            while (!valid)
                            {
                                Console.WriteLine("Play Again? (y/n)");
                                playAgain = Console.ReadLine().ToLower();
                                if (playAgain == "y")
                                {
                                    valid = true;
                                    gameover = true;
                                }
                                else if (playAgain == "n")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Play Again? (y/n)");
                                }
                            }
                        }
                    }
                    else if (incorrect == 5)
                    {
                        Console.WriteLine("  +---+");
                        Console.WriteLine("  |   |");
                        Console.WriteLine("  O   |");
                        Console.WriteLine(" /|\\  |");
                        Console.WriteLine(" /    |");
                        Console.WriteLine("      |");
                        Console.WriteLine("=========");
                        Console.WriteLine(progress);
                        Console.WriteLine();
                        Console.Write("Guess a Letter: ");
                        valid = false;
                        while (!valid)
                        {
                            guessString = Console.ReadLine().ToUpper();
                            if (char.TryParse(guessString, out guess) && Regex.IsMatch(guessString, @"^[a-zA-Z]+$") && !letters.Contains(guess))
                            {
                                valid = true;
                                letters.Add(guess);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Guess");
                            }
                        }
                        if (word.Contains(guess))
                        {
                            indexReplace = 0;
                            foreach (char c in word)
                            {
                                if (c == guess)
                                {
                                    indexReplace = (word.IndexOf(c, indexReplace)) * 3 + 1;
                                    progress = progress.Remove(indexReplace, 1).Insert(indexReplace, Convert.ToString(guess));
                                }
                            }
                        }
                        else
                        {
                            incorrect++;
                        }
                        if (!progress.Contains("_"))
                        {
                            Console.Clear();
                            Console.WriteLine("YOU WIN!!!");
                            valid = false;
                            while (!valid)
                            {
                                Console.WriteLine("Play Again? (y/n)");
                                playAgain = Console.ReadLine().ToLower();
                                if (playAgain == "y")
                                {
                                    valid = true;
                                    gameover = true;
                                }
                                else if (playAgain == "n")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Play Again? (y/n)");
                                }
                            }
                        }
                    }
                    else if (incorrect == 6)
                    {
                        Console.WriteLine("  +---+");
                        Console.WriteLine("  |   |");
                        Console.WriteLine("  O   |");
                        Console.WriteLine(" /|\\  |");
                        Console.WriteLine(" / \\  |");
                        Console.WriteLine("      |");
                        Console.WriteLine("=========");
                        Console.WriteLine("YOU LOSE");
                        Console.WriteLine($"THE WORD WAS {word}!");
                        valid = false;
                        while (!valid)
                        {
                            Console.WriteLine("Play Again? (y/n)");
                            playAgain = Console.ReadLine().ToLower();
                            if (playAgain == "y")
                            {
                                valid = true;
                                gameover = true;
                            }
                            else if (playAgain == "n")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Play Again? (y/n)");
                            }
                        }
                    }
                }
            }
        }
    }
}
