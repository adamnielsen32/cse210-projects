using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I learned today?",
        "What was a challenge I faced today and how did I overcome it?",
        "What is something I am grateful for today?",
        "What is a goal I accomplished today?",
        "What is something that made me laugh today?",
        "What is a new idea I had today?",
        "What is something I did today that I am proud of?",
        "What is a mistake I made today and what did I learn from it?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}