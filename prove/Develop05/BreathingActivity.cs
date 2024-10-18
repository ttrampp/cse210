using System;

class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity is designed to help you relax by breathing in and out slowly. \n\nClear your mind and focus on your breathing.", duration)
    {

    }
    public override void RunActivity()
    {
        DisplayStartingMessage("Breathing Activity");

        for (int i = 0; i < _duration / 15; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Slowly breathe in through the nose...");
            ShowCountDown(4);
            Console.WriteLine("Hold it...");
            ShowCountDown(4);
            Console.WriteLine("Slowly breathe out through the mouth...");
            ShowCountDown(4);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}