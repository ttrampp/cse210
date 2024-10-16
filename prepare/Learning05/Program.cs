using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignmentM1 = new MathAssignment("August", "Math 7/8", "Lesson 4", "1-30 evens only");
        MathAssignment assignmentM2 = new MathAssignment("Adam", "Math 7/8", "Lesson 5", "1-30");

        WritingAssignment assignmentW1 = new WritingAssignment("August", "Grammar & Writing 8", "Topic Sentences");
        WritingAssignment assignmentW2 = new WritingAssignment("Adam", "Grammar & Writing 8", "Paragraph Structure");

        Console.WriteLine();
        Console.WriteLine(assignmentM1.GetSummary() + "; " + assignmentM1.GetHomeworkList());
        Console.WriteLine(assignmentW1.GetSummary() + "; " + assignmentW1.GetWritingInformation());
        Console.WriteLine();
        Console.WriteLine(assignmentM2.GetSummary() + "; " + assignmentM2.GetHomeworkList());
        Console.WriteLine(assignmentW2.GetSummary() + "; " + assignmentW2.GetWritingInformation());
        Console.WriteLine();

    }
}