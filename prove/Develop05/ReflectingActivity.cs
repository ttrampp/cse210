using System;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;


    public ReflectingActivity(int duration) : base("ReflectingActivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThese are to help remind you how you can continue to stay strong. \n you will be given a subject prompt and then questions to think about that subject.", duration)
    {

        _prompts = new List<string>
        {
            "Think of a time when you did service for someone.",
            "Think of a time when you were faced with a difficult challenge.",
            "Think of a time when you did something to or for someone else and nobody knew about it.",
            "Think of a time when you stood up for someone else."
        };

        _questions = new List<string>
        {
            "Did you go to bed in peace that night, and why?",
            "What did you learn about yourself from this experience? ",
            "If you could, what would you change about the things you did? ",
            "How does this connect with other areas of your life?",
            "What advice would you give about this type of situation?",
            "How often do you relate this to other things in your life?",
            "How was this meaningful to you?"

        };
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public override void RunActivity()
    {
        DisplayStartingMessage("Reflecting Activity");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"\n{question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}