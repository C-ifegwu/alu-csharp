using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";

        for (int i = 0; i < 100; i++)
        {
            output += i.ToString("D2");
            if (i != 99)
                output += ", ";
        }

        Console.Write(output + "\n");
    }
}