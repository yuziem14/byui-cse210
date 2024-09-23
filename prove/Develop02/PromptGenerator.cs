using System;

public class PromptGenerator {
    private List<string> _prompts = new List<string>() {
        "How was your day?",
        "What was the most surprising event of my day?",
        "What would I like my future generations to know about this day?",
        "What is one thing I learned today?",
        "What is important to note about this day?"
    };
    public Random _randomGenerator;

    public PromptGenerator()
    {
        _randomGenerator = new Random();
    }

    public string GetRandomPrompt() {
        int index = _randomGenerator.Next(0, 5);
        return _prompts[index];
    }
}