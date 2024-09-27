using System;

class Program
{
    static void Main(string[] args)
    {
        //Welcome message and option message
        Console.WriteLine("Welcome to the Journal Entry Program");
        Console.WriteLine("Please type the number you want from one of the options below.");
        int optionChoice = DisplayChoicesMenu();
        //int optionChoice = int.Parse(Console.ReadLine());
        Journal journal = new Journal();

        //Displaying options and looping back through option choices
        while (optionChoice != 5)
        {


            //Option 1
            if (optionChoice == 1)
            {
                journal.CreateNewEntry();

                Console.WriteLine("Alright! Journaling is beneficial for the future.");
                //int optionChoice = 
                DisplayChoicesMenu();
            }

            //Option 2
            else if (optionChoice == 2)
            {
                journal.DisplayAll();
                DisplayChoicesMenu();
            }

            //Option 3
            else if (optionChoice == 3)
            {
                journal.SaveToFile();
                DisplayChoicesMenu();
            }

            //Option 4
            else if (optionChoice == 4)
            {
                journal.LoadFromFile();
                DisplayChoicesMenu();
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
                DisplayChoicesMenu();
            }
            
        }

        static int DisplayChoicesMenu()
        {
            List<string> choicesMenu = new List<string>();
            {
                choicesMenu.Add("Enter '1' --Create a new journal entry.");
                choicesMenu.Add("Enter '2' --Display All the journal entries thus far.");
                choicesMenu.Add("Enter '3' --Save journal to file.");
                choicesMenu.Add("Enter '4' --Load or open a journal file.");
                choicesMenu.Add("Enter '5' --Quit for now.");

                //print to screen option choices for user
                foreach (string choice in choicesMenu)
                {
                    Console.WriteLine(choice);
                }

                Console.Write("Make your number selection: ");
                int optionChoice = int.Parse(Console.ReadLine());

                return optionChoice; 
            }

        }

    }
}