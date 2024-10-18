using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _itemsListed;

    public ListingActivity(int duration) : base("Listing Activity", "\nThis activity will help you reflect on times in your life where you shown strength or success \nThis is done by having you list as many things as you can think of within a small amount of time.", duration)
    {
        _prompts = new List<string>
        {
            "Who are the people that lift you up?",
            "What are some of your strengths?",
            "When have you seen Christ's tender mercies this week?",
            "Who are some people you admire?"
        };

        _itemsListed = new List<string>();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    //you can do this tanya, keep going, don't quit!!!
    public override void RunActivity()
    {
        DisplayStartingMessage("Listing Activity");

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");

        ShowCountDown(5);
        Console.WriteLine($"List as many things as you can. Press Enter after each item. Don't worry about spelling.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                _itemsListed.Add(item);
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You listed the following: ");
        foreach (string item in _itemsListed)
        {
            Console.WriteLine($" = {item}");
        }

        Console.WriteLine($"You listed {_itemsListed.Count} items.");

        DisplayEndingMessage();

    }

}