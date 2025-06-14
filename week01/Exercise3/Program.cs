using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // Generates a number between 1 and 100
        Console.Write("What is the magic number? ");
        string guess = Console.ReadLine();
        int guessedNumber = int.Parse(guess);
        while (guessedNumber != magicNumber)
        {
            if (guessedNumber < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }
            Console.Write("What is the magic number? ");
            guess = Console.ReadLine();
            guessedNumber = int.Parse(guess);
        }
        Console.WriteLine("Congratulations! You guessed the magic number.");
    }
}