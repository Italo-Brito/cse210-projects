using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            return Name;
        }

        static int PromptUserNumber()
        {
           Console.Write("Please enter your number: ");
            int number = int.Parse(Console.ReadLine());             
            return number;
        }
        static int SquareNumber(int number)
        {
            int Square = number * number;
            return Square;
        }
        static void DisplayResult(string Name, int Square)
        {
            Console.WriteLine($"{Name}, the square of your number is: {Square} ");
        }
    }
}