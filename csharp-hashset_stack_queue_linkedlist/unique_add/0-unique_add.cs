using System;
using System.Collections.Generic;

public static class List
{
    public static int Sum(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            return 0;
        }
        
        // Use HashSet to get unique values
        HashSet<int> uniqueNumbers = new HashSet<int>();
        int sum = 0;
        
        foreach (int num in myList)
        {
            // Add returns true if element was added (wasn't already in set)
            if (uniqueNumbers.Add(num))
            {
                sum += num;
            }
        }
        
        return sum;
    }
using System;
using System.Collections.Generic;

public static class List
{
    public static int Sum(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            return 0;
        }
        
        // Use HashSet to get unique values
        HashSet<int> uniqueNumbers = new HashSet<int>();
        int sum = 0;
        
        foreach (int num in myList)
        {
            // Add returns true if element was added (wasn't already in set)
            if (uniqueNumbers.Add(num))
            {
                sum += num;
            }
        }
        
        return sum;
    }
}