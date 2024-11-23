using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What is one thing you learn today?",
            "Who made your day today awesome?",
            "what experience of the Lord did you felt today?",
            "What is one things you wish to improve on today?",
            "If you have the means what would you have done better?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}