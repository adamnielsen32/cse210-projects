using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int userNumber = int.Parse(input);
            return userNumber;
        }
        static int SquareNumber(int usernumber)
        {
            return usernumber * usernumber;
        }
        static void DisplayResult(string userName, int userNumber, int squaredNumber)
        {
            Console.WriteLine($"Hello {userName}, your favorite number is {userNumber} and its square is {squaredNumber}.");
        }
        static void MainProgram()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(userName, userNumber, squaredNumber);
        }
        MainProgram();

    }
}