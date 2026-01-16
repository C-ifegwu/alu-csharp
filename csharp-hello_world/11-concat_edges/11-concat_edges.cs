using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
        str = str.Substring(49, 14) + str.Substring(78, 11) + str.Substring(116, 4) + str.Substring(100, 4);
        Console.WriteLine(str);
    }
}