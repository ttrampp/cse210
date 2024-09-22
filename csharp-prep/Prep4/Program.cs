using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;   //added per core requirements

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int nG = -1;
        

        do
        {
            Console.WriteLine("Please enter a number. (Enter 0 to quit): ");
            string numGiven = Console.ReadLine();
            nG = int.Parse(numGiven);
            
            numbers.Add(nG);
    
        } while (nG != 0);

        //print list for testing
        //numbers.ForEach(Console.WriteLine);


        //Compute the sum, or total, of the numbers in the list.--Core Requirement 1
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The total of the numbers in the list is: {total}");

        //Compute the average of the numbers in the list.--Core Requirement 2
        numbers.Remove(0);      //added for stretch challenge
        float average = ((float)total) / numbers.Count;
        double truncatedAverage = Math.Round(average, 3);
        Console.WriteLine($"The average of the list numbers is: {truncatedAverage}.");

        //Find the maximum, or largest, number in the list.--Core Requirement 3
        int max = numbers.Max();
        Console.WriteLine($"The largest number in the list is: {max}");

        //Stretch Challenges
        //Stretch Callenge 1: Have the user enter both positive and negative numbers, then find the smallest positive number (the positive number that is closest to zero).
       
        ////int min = numbers.Min();
        ////Console.WriteLine($"The smallest number in the list is: {min}");

        List<int> positiveNumbers = new List<int>();
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                positiveNumbers.Add(number);
            }
        }

        //print list for testing
        //positiveNumbers.ForEach(Console.WriteLine);

        int minPos = positiveNumbers.Min();
        Console.WriteLine($"The smallest positive number in the list is: {minPos}");


        //Stretch Challenge 2: Sort the numbers in the list and display the new, sorted list. Hint: There are C# libraries that can help you here, try searching the internet for them.
        
        //Additional stretch challenge code above to ensure average comes out correctly formatted/rounded.
        numbers.Sort();
        
        numbers.ForEach(Console.WriteLine);

    }
}
