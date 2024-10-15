// ADDED CODE FOR SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS 
//-- MENU OPTIONS FOR USER TO CHOOSE SCRIPTURE TO PRACTICE
//-- COLORING AND SPACING FOR USER EASE OF READABILITY


using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace ScriptureMem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Scripture> scriptures = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "\n\tFor God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, \n\tbut have everlasting life.\n"),
                new Scripture(new Reference("Psalm", 34, 4), "\n\tI sought the Lord, and he heard me, and delivered me from all my fears.\n"),
                new Scripture(new Reference("Leviticus", 7, 11, 12), "\n\tAnd this is the law of the sacrifice of peace offerings, which he shall offer unto the Lord.\n\t If he offer it for a thanksgiving, then he shall offer with the sacrifice of thanksgiving \n\tunleavened cakes mingled with oil, and unleavened wafers anointed with oil, and cakes mingled with oil, \n\tof fine flour, fried.\n")
            };

            while (true)
            {
                DisplayMenu();
                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "Q")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Have a good day. Come back soon");
                    break;
                }

                if (int.TryParse(userInput, out int scriptureOption) && scriptureOption >= 1 && scriptureOption <= scriptures.Count)
                {
                    PracticeScripture(scriptures[scriptureOption - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                }
            }
        }



        //user select scripture menu
        static void DisplayMenu()
        {
            Console.WriteLine("**********WELCOME TO THE SCRIPTURE MEMORIZER**********");
            Console.WriteLine("The scripture of choice will first be shown in full, so take your time to read it thoroughly. ");
            Console.WriteLine("When you are ready, we will start hiding 5 words at a time. ");
            Console.WriteLine("You've got this!");
            Console.WriteLine();
            Console.WriteLine("Please enter the number for which scripture you would like to practice on:");
            Console.WriteLine("1) John 3:16");
            Console.WriteLine("2) Psalm 34:4");
            Console.WriteLine("3) Leviticus 7:11-12");
            Console.WriteLine("Q) Press Q if you would like to quit.");
        }



        static void PracticeScripture(Scripture scripture)
        {
            Console.Clear();
            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine(scripture.GetDisplayText());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press Enter to hide 5 words, or enter to quit.");

                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    scripture.HideRandomWords(5);
                }
                else if (key.Key == ConsoleKey.Q)
                {
                    break;
                }
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Good job practicing ");
                Console.WriteLine(scripture.GetReference().GetDisplayReference());
                Console.WriteLine("Come back to practice again soon!");
                Console.BackgroundColor = ConsoleColor.Black;
                Environment.Exit(0);
            }
        }



    }

}
