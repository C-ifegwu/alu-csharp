using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";

        for (int i = 0; i <= 98; i++)
        {
            result += $"{i} = 0x{i:x}\n";
        }

        Console.Write(result);
    }
}
