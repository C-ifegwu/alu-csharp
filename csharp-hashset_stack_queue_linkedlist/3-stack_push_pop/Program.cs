using System;
using System.Collections.Generic;

public static class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        if (list1 == null && list2 == null)
        {
            return new List<int>();
        }
        
        HashSet<int> set1 = new HashSet<int>(list1 ?? new List<int>());
        HashSet<int> set2 = new HashSet<int>(list2 ?? new List<int>());
        List<int> result = new List<int>();
        
        // Find elements in set1 but not in set2
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                result.Add(num);
            }
        }
        
        // Find elements in set2 but not in set1
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                result.Add(num);
            }
        }
        
        // Sort the result
        result.Sort();
        
        return result;
    }
}