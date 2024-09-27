public class Entry
{
    //setting variables
    public string _date;
    public string _promptText;
    public string _entryText;

    //Displaying variable info. on hold until called
    public void DisplayEntry()
    {
        Console.WriteLine($"Entry Date: {_date}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}