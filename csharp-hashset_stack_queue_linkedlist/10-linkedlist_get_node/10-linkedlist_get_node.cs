using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0 || n >= myLList.Count)
        {
            return 0;
        }

        int index = 0;
        foreach (int item in myLList)
        {
            if (index == n)
            {
                return item;
            }
            index++;
        }
        return 0;
    }
}