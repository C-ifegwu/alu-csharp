using System;
using System.Collections.Generic;

/// <summary>
/// Class for list operations
/// </summary>
class List
{
    /// <summary>
    /// Divides element by element two lists
    /// </summary>
    /// <param name="list1">First list (numerators)</param>
    /// <param name="list2">Second list (denominators)</param>
    /// <param name="listLength">Number of elements to divide</param>
    /// <returns>A new list with division results</returns>
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                int division = list1[i] / list2[i];
                result.Add(division);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        
        return result;
    }
}
