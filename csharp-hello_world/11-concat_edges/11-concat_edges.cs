using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		str = str.Substring(56, 19) + str.Substring(0, 2) + str.Substring(2, 1) + str.Substring(3, 1) + str.Substring(4, 1) + str.Substring(5, 1) + str.Substring(6, 1) + str.Substring(7, 1) + str.Substring(8, 1) + str.Substring(9, 1) + str.Substring(10, 1);
		Console.WriteLine(str);
	}
}