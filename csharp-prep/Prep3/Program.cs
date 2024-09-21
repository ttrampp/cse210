using System;
using System.Formats.Asn1;
using System.Formats.Tar;

class Program
{
    static void Main(string[] args)
    {
        //Stretch challenge added. keep track of number of tries taken AND option to play again.
        string playGame;
        do
        {
            //Next three lines of comments were for Core Requirements 1 & 2.
            //Console.Write("What is the magic number? ");
            //string magicNumber = Console.ReadLine();
            //int mN = int.Parse(magicNumber);

            //Core Requirement 3--Random number generated for magic number
            Random randomGenerator = new Random();
            int mN = randomGenerator.Next(1, 1001);

            int guess = -1;
            int tries = 0;
            //string playGame;
            do
            {
                Console.Write($"My guess is: ");
                guess = int.Parse(Console.ReadLine());
                
                tries += 1;

                if (guess > mN)
                {
                Console.WriteLine("Lower");
                }

                else if (guess < mN)
                {
                Console.WriteLine("Higher");
                }

                else
                {
                Console.WriteLine("You guessed it!");
                }
            } while (guess != mN);
            Console.WriteLine($"You made {tries} guesses.");
            Console.Write("Would you like to play again? (y/n)");
            playGame = Console.ReadLine();

        } while (playGame == "y" || playGame == "yes");
        
    }
}