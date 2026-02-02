using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            return;
        }

        int currentIdx = 0;
        LinkedListNode<int> current = myLList.First;
        while (current != null)
        {
            if (currentIdx == index)
            {
                myLList.Remove(current);
                return;
            }
            current = current.Next;
            currentIdx++;
        }
    }
}