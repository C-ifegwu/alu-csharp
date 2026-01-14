using System;

class Program
{
	static void Main(string[] args)
	{
		string str1 = "Holberton";
		string str2 = "School";
		str1 = String.Format("Welcome to {0} {1}!", str1, str2);
		Console.WriteLine(str1);
	}
}