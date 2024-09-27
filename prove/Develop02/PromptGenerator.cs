public class PromptGenerator
{
    //Making sure prompt is random
    public Random random = new Random();

    //creates a list of propmts
    public List<string> _prompts = new List<string>(){
        "What is your Happy Thought for today? ",
        "One word describing today? "
    };

    //Returning a random prompt from list above and not just the same one each time
    public string GetRandomPrompt()
    {

        return _prompts[random.Next(0, _prompts.Count)];
    }
}