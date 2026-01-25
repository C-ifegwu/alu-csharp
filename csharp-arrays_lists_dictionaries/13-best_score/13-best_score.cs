using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            return "None";
        }

        string bestKey = "None";
        int maxVal = -1;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > maxVal)
            {
                maxVal = entry.Value;
                bestKey = entry.Key;
            }
        }

        return bestKey;
    }
}