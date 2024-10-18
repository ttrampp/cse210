// Added code for showing creativity and exceeding requirements:
// Showing how many times activies were performed
// Color changing for user ease on eyes



using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter the duration in seconds: ");
                    int durationBreathing = int.Parse(Console.ReadLine());
                    Activity breathingActivity = new BreathingActivity(durationBreathing);
                    breathingActivity.RunActivity();
                    break;

                case "2":
                    Console.WriteLine("Enter the duration in seconds: ");
                    int durationReflecting = int.Parse(Console.ReadLine());
                    Activity reflectingActivity = new ReflectingActivity(durationReflecting);
                    reflectingActivity.RunActivity();
                    break;

                case "3":
                    Console.WriteLine("Enter the duration in seconds: ");
                    int durationListing = int.Parse(Console.ReadLine());
                    Activity listingActivity = new ListingActivity(durationListing);
                    listingActivity.RunActivity();
                    break;

                case "4":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to return to the menu options.");
                Console.ReadKey();
            }

        }
        Console.WriteLine("Come back soon!");
    }
}