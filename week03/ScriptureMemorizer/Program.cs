using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart, and lean not on your own understanding; in all your ways acknowledge Him, and He shall direct your paths.";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {

            Console.Clear();
            Console.WriteLine(scripture.GetScriptureText());
            Console.WriteLine("Press Enter to hide some words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
            
            
        }

        Console.Clear();
        Console.WriteLine("Congratulations! You have memorized the scripture.");
    }
}