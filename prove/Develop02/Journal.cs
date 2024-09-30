public class Journal
{
    //defining variables
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator _prompts = new PromptGenerator();

    
    //Preparing values for variables that are defined in Entry.cs to be added to other compiled Entries, then adding them
    public void CreateNewEntry() //(Entry newEntry)
    {
        Entry _entry = new Entry();
        _entry._date = DateTime.Now.ToShortDateString();
        _entry._promptText = _prompts.GetRandomPrompt();
        Console.WriteLine($"Prompt: {_entry._promptText}");
        _entry._entryText = Console.ReadLine();

        _entries.Add(_entry);
    }

    //method to for printing to screen all previously added entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    //Saving the new entry into file with all other compiled entries
    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                sw.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    //loading up saved file to display when prompted. Method to update entries, ensuring there are not duplicates and there are clear seperaters between lines/parts of info
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry _entry = new Entry();
            _entry._date = parts[0];
            _entry._promptText = parts[1];
            _entry._entryText = parts[2];

            _entries.Add(_entry);
        }
    }
}