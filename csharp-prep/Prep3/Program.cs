using System;
using System.Formats.Tar;

class Program
{
    static void Main(string[] args)
    {
        //Next three lines of comments were for Core Requirements 1 & 2.
        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int mN = int.Parse(magicNumber);

        //Core Requirement 3--Random number generated for magic number
        Random randomGenerator = new Random();
        int mN = randomGenerator.Next(1, 1001);

        int guess = -1;

        do
        {
            Console.Write($"My guess is: ");
            guess = int.Parse(Console.ReadLine());
            //int guessNum = int.Parse(guess);

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
        
        
    }
}