using System;

class Program
{
    static void Main(string[] args)
    {
        bool first = true;

        for (int i = 0; i <= 8; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                if (!first)
                    Console.Write(", ");

                Console.Write($"{i}{j}");
                first = false;
            }
        }

        Console.WriteLine();
    }
}