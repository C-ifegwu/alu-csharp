using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);
        
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }

        bool contains = aStack.Contains(search);
        Console.WriteLine("Stack contains \"" + search + "\": " + contains);

        if (contains)
        {
            while (aStack.Count > 0)
            {
                string item = aStack.Pop();
                if (item == search)
                {
                    break;
                }
            }
        }

        aStack.Push(newItem);
        return aStack;
    }
}