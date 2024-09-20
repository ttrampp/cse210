using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter you percentage grade: ");
        string percentageGrade = Console.ReadLine();

        int p = int.Parse(percentageGrade);
        string letter = "";

        if (p >= 90)
        {
            letter = "A";
        }

        else if (p < 90 && p >= 80)
        {
            letter = "B";
        }

        else if (p < 80 && p >= 70)
        {
            letter = "C";
        }

        else if (p < 70 && p >= 60)
        {
            letter = "D";
        }
        
        else
        {
            letter = "F";
        }
        
        string letterSign = "";

        int lastDigit = p % 10;

        if (p >= 60 && p < 90 && lastDigit >= 7)
        {
            letterSign = "+";
        }

        else if (p >= 60 && lastDigit <= 3)
        {
            letterSign = "-";
        }

        else
        {
            letterSign = "";
        }
        
        Console.WriteLine($"Your grade is {letter}{letterSign}.");
        
        if (p >= 70)
        {
            Console.WriteLine("Congratulations! You passed!!");
        }

        else
        {
            Console.WriteLine("Unfortunately you did not pass. Keep studying. You can do this!");
        }
    }
}