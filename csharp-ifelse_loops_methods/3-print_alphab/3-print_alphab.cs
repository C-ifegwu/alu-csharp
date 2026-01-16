using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (c != 'e' && c != 'q')
            {
                output += c;
            }
        }

        Console.Write(output);
    }
}