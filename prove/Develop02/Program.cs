using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int optionChoice = -1;

        //Displaying options and looping back through option choices
        while (optionChoice != 5)
        {
            //Welcome message and option message
            Console.WriteLine("Welcome to the Journal Entry Program");
            Console.WriteLine("Please type the number you want from one of the options below.");

            Console.WriteLine("Enter '1' --Create a new journal entry.");
            Console.WriteLine("Enter '2' --Display All the journal entries thus far.");
            Console.WriteLine("Enter '3' --Save journal to file.");
            Console.WriteLine("Enter '4' --Load or open a journal file.");
            Console.WriteLine("Enter '5' --Quit for now.");

            optionChoice = int.Parse(Console.ReadLine());

            //Option 1
            if (optionChoice == 1)
            {
                journal.CreateNewEntry();

                Console.WriteLine("Alright! Journaling is beneficial for the future.");
            }

            //Option 2
            else if (optionChoice == 2)
            {
                journal.DisplayAll();
            }

            //Option 3
            else if (optionChoice == 3)
            {
                journal.SaveToFile("MyJournal.txt");
            }

            //Option 4
            else if (optionChoice == 4)
            {
                journal.LoadFromFile("MyJournal.txt");
            }

            //Option 5
            else if (optionChoice == 5)
                {
                    Console.WriteLine("Take care. Come back again soon!");
                    break;
                }

            else
            {
                Console.WriteLine("Invalid response. Please try again.");
            }
            
        }
    }
}