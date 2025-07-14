

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) : base("Reflecting", "This activity will help you reflect on the good things in your life by having you think deeply about them.", duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you felt truly happy. What were the circumstances?",
            "Reflect on a challenge you overcame. What did you learn from it?",
            "Consider a person who has had a positive impact on your life. What did they do that made a difference?",
            "Think about a moment when you felt proud of yourself. What led to that feeling?",
            "Recall a time when you felt at peace. What contributed to that sense of calm?"
        };
        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };  
    }

    private string GetRandomPrompt()
{
    Random rand = new Random();
    return _prompts[rand.Next(_prompts.Count)];
}

private string GetRandomQuestion()
{
    Random rand = new Random();
    return _questions[rand.Next(_questions.Count)];
}

public void Run()
{
    DisplayStartingMessage();

    Console.WriteLine("\nConsider the following prompt:");
    Console.WriteLine($"--- {GetRandomPrompt()} ---");
    Console.WriteLine("When you have something in mind, press Enter.");
    Console.ReadLine();
    Console.WriteLine("Now ponder on each of the following questions:");
    ShowSpinner(3);

    DateTime end = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < end)
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(5);
        Console.WriteLine();
    }

    DisplayEndingMessage();
}

}