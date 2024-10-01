using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstC = new Fraction();
        Console.WriteLine(firstC.GetFractionString());
        Console.WriteLine(firstC.GetDecimalValue());

        Fraction secondC = new Fraction(5);
        Console.WriteLine(secondC.GetFractionString());
        Console.WriteLine(secondC.GetDecimalValue());

        Fraction thirdC = new Fraction(3,4);
        Console.WriteLine(thirdC.GetFractionString());
        Console.WriteLine(thirdC.GetDecimalValue());

        Fraction fourthC = new Fraction(1,3);
        Console.WriteLine(fourthC.GetFractionString());
        Console.WriteLine(fourthC.GetDecimalValue());
    }
}