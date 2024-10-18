using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Activity
{
    private string _activityName;
    private string _description;
    protected int _duration;

    private static int _breathingCount = 0;
    private static int _reflectingCount = 0;
    private static int _listingCount = 0;
    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    public virtual void RunActivity()
    {
        RunActivity();
    }

    protected void ActivityCount()
    {
        if (_activityName == "Breathing Activity")
            _breathingCount++;
        else if (_activityName == "Reflecting Activity")
            _reflectingCount++;
        else if (_activityName == "Listing Activity")
            _listingCount++;
    }

    public static void DisplayActivityCount()
    {
        Console.WriteLine("This is how many times each activity was performed:");
        Console.WriteLine($"Breathing Activity -- {_breathingCount} times.");
        Console.WriteLine($"Reflecting Activity -- {_reflectingCount} times.");
        Console.WriteLine($"Listing Activity -- {_listingCount} times.");
        Console.WriteLine();
    }

    public void DisplayStartingMessage(string activityName)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nWelcome to the Mindfulness Program");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"You have selected the {activityName}.");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"\nThis activity will last for {_duration} seconds.");
        Console.WriteLine($"Prepare to begin...");
        ShowSpinner(1);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("You did great!");
        Console.WriteLine($"\nYou have completed the {_activityName} for {_duration} seconds.");
        Console.WriteLine("Don't forget to give yourself a high-five and a smile. You did good today.");
        //ShowSpinner(1);
    }


    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();

        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);

        }
        Console.WriteLine();
    }
}