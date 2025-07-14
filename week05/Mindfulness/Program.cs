using System;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Hello World! This is the Mindfulness Project.");
       
        
            string choice = "";
            while (choice != "4")
            {
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflecting Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Choose an option: ");
                choice = Console.ReadLine();

                if (choice == "1")
                    new BreathingActivity(60).Run();
                else if (choice == "2")
                    new ReflectingActivity(60).Run();
                else if (choice == "3")
                    new ListingActivity(60).Run();
            }
        
    }

    
}