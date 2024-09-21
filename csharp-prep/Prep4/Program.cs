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
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average of the list numbers is: {average}.");

        //Find the maximum, or largest, number in the list.--Core Requirement 3
        int max = numbers.Max();
        Console.WriteLine($"The largest number in the list is: {max}");

    }
}
