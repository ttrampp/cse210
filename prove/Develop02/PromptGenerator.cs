public class PromptGenerator
{
    //Making sure prompt is random
    public Random random = new Random();

    //creates a list of propmts
    public List<string> _prompts = new List<string>(){
        "My Happy Thought for today is... ",
        "One word describing today would be... ",
        "One thing I would like to change about today is... ",
        "The best thing about today was... ",
        "One thing that helped strengthen my testimony today was...",
        "One thing I learned today was... "

    };

    //Returning a random prompt from list above and not just the same one each time
    public string GetRandomPrompt()
    {

        return _prompts[random.Next(0, _prompts.Count)];
    }
}