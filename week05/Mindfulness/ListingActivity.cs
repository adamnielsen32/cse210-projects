

using System.Dynamic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int duration) : base("Listing", "This activity will help you reflect on the good things in your life by having you list them.", duration)
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "What was the highlight of your week?",
            "What is something you are looking forward to?",
            "What is a positive affirmation you can tell yourself?",
            "What is a small win you had recently?"
        };
    }

       private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
    
    public void Run()
    {
        DisplayStartingMessage();
    
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
    
        List<string> responses = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
                responses.Add(input);
        }

        _count = responses.Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    
    }