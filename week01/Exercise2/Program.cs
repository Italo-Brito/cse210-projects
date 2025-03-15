using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 2 Project.");

        Console.Write("What is your grade porcentage? ");
        string unserInput =  Console.ReadLine();
        float grade = float.Parse(unserInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats, you passed!!!!");
        }
        else
        {
            Console.WriteLine("Unfortunately you didn't get enough grade to pass, please try again next time.");
        }
    }
    
}