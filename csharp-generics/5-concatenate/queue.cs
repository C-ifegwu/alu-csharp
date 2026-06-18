using System;

/// <summary>
/// A simple generic queue implemented as a singly-linked list.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
public class Queue<T>
{
    // Node class
    public class Node
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public T value;

        /// <summary>
        /// Reference to the next node in the queue, or <c>null</c> if this is the last node.
        /// </summary>
        public Node? next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>
    /// The head (front) node of the queue.
    /// </summary>
    public Node? head;

    /// <summary>
    /// The tail (rear) node of the queue.
    /// </summary>
    public Node? tail;

    /// <summary>
    /// Number of elements currently in the queue.
    /// </summary>
    private int count;



    /// <summary>
    /// Returns the <see cref="Type"/> instance for the generic parameter <c>T</c>.
    /// </summary>
    /// <returns>The runtime <see cref="Type"/> for <c>T</c>.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Adds a value to the end of the queue.
    /// </summary>
    /// <param name="value">The value to enqueue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (count == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>
    /// Removes and returns the element at the front of the queue.
    /// </summary>
    /// <returns>The dequeued element, or the default value for <c>T</c> when the queue is empty.</returns>
    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T)!;
        }

        T value = head!.value;
        head = head.next;
        count--;

        if (count == 0)
            tail = null;

        return value;
    }

    /// <summary>
    /// Returns the element at the front of the queue without removing it.
    /// </summary>
    /// <returns>The front element, or the default value for <c>T</c> when the queue is empty.</returns>
    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T)!;
        }

        return head!.value;
    }

    /// <summary>
    /// Gets the number of elements in the queue.
    /// </summary>
    /// <returns>The current element count.</returns>
    public int Count()
    {
        return count;
    }

    public void Print()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node? current = head;

        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    public string? Concatenate()
    {
        /// <summary>
        /// Concatenates the string or char elements in the queue into a single string.
        /// </summary>
        /// <returns>
        /// A concatenated string when the generic type is <c>string</c> or <c>char</c>.
        /// Returns <c>null</c> if the queue is empty or the element type is not supported.
        /// </returns>
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        Node? current = head;
        string result = "";

        while (current != null)
        {
            if (typeof(T) == typeof(string))
                result += current.value + " ";
            else // char
                result += current.value;

            current = current.next;
        }

        return result.TrimEnd();
    }
}