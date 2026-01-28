using System;
using System.Collections.Generic;

public static class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        if (list1 == null || list2 == null)
        {
            return new List<int>();
        }
        
        HashSet<int> set1 = new HashSet<int>(list1);
        List<int> result = new List<int>();
        
        // Find common elements
        foreach (int num in list2)
        {
            if (set1.Contains(num))
            {
                result.Add(num);
            }
        }
        
        // Sort the result
        result.Sort();
        
        return result;
    }
}