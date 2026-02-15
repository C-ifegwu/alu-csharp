using System;

/// <summary>
/// Class for integer operations
/// </summary>
class Int
{
    /// <summary>
    /// Divides two integers and prints the result using try/catch/finally
    /// </summary>
    /// <param name="a">First integer</param>
    /// <param name="b">Second integer</param>
    public static void divide(int a, int b)
    {
        int result = 0;
        
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, result);
        }
    }
}
