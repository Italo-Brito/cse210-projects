using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 3 Project.");

        Console.Write("What is the magic number? ");
        string lnumber = Console.ReadLine();
        float number = float.Parse(lnumber);

        float gnumber = -1;
        string lgnumber;

        while(gnumber != number)
        {
            Console.Write("What is your guess?");
            lgnumber = Console.ReadLine();
            gnumber = float.Parse(lgnumber);  

            if (gnumber > number)
            {
                Console.WriteLine("Lower");
            }
            else if (gnumber < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You Guessed it!");
            }
        }

        

    }
}