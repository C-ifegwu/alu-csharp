using System;
using System.Collections.Generic;

public static class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print number of items
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        
        // Print first item or "Queue is empty"
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        
        // Add new item to queue
        aQueue.Enqueue(newItem);
        
        // Print if queue contains search item
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, containsSearch);
        
        // If queue contains search, remove all items up to and including search
        if (containsSearch)
        {
            // Since we can only use Dequeue() once, we'll use a different approach
            // Convert queue to list
            List<string> items = new List<string>(aQueue);
            aQueue.Clear();
            
            // Find index of search item
            int index = items.IndexOf(search);
            
            // Add items after the search item (excluding search itself)
            for (int i = index + 1; i < items.Count; i++)
            {
                aQueue.Enqueue(items[i]);
            }
        }
        
        return aQueue;
    }
}