using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("-------------Enter a list of numbers, type 0 when finished.---------------");

        List<int> numbers = new List<int>();

        int unumber = -1;
        string lnumber;

        while (unumber != 0)
        {
            Console.Write("Enter Number: ");
            lnumber = Console.ReadLine();
            unumber = int.Parse(lnumber);
            
            if (unumber != 0)
            {
                numbers.Add(unumber);
            }
            
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The Sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The Average is: {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The Largest Number is: {largest}");
    }
}