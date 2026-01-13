using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = .2641;
        double currency = 12345.678;
        Console.WriteLine("Percent: {0:P2}", percent);
        Console.WriteLine("Currency: {0:C2}", currency);
    }
}