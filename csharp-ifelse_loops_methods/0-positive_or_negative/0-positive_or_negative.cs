using System;

class Program
{
    static void Main(string[] args)
    {
        int number;

        // For positive case
        number = 98;

        // For zero case
        // number = 0;

        if (number > 0)
        {
            Console.WriteLine($"{number} is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number} is negative");
        }
        else
        {
            Console.WriteLine($"{number} is zero");
        }
    }
}