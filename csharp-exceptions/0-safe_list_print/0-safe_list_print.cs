using System;
using System.Collections.Generic;

/// <summary>
/// Class for safe list operations
/// </summary>
class List
{
    /// <summary>
    /// Prints n elements of a list safely using try/catch
    /// </summary>
    /// <param name="myList">The list to print from</param>
    /// <param name="n">Number of elements to print</param>
    /// <returns>Number of elements actually printed</returns>
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        
        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                count++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            // If we try to access an index that doesn't exist, stop printing
        }
        
        return count;
    }
}
