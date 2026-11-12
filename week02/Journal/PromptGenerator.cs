public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator() 
    {
        _prompts = new List<string>
        {
            "What made you happy today?",
            "What is something you are grateful for?",
            "What did you learn today?",
            "What is a challenge you faced and how did you overcome it?",
            "What is something you would like to improve about yourself?"
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}