using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
{
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string response = "";

        while (response != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("Your response: ");
                        string entryText = Console.ReadLine();

                        Entry entry = new Entry(prompt, entryText);
                        journal.AddEntry(entry);
                    }
                    else if (choice == "2")
                    {
                        journal.DisplayAll();
                    }
                    else if (choice == "3")
                    {
                        Console.Write("Enter filename to save: ");
                        string filename = Console.ReadLine();
                        journal.SaveToFile(filename);
                    }
                    else if (choice == "4")
                    {
                        Console.Write("Enter filename to load: ");
                        string filename = Console.ReadLine();
                        journal.LoadFromFile(filename);
                        
            }
                    else if (choice == "5")
                    {
                        response = "5";
                        Console.WriteLine("Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    }
        }
    }
}

    }
}