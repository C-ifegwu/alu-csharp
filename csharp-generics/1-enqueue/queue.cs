using System;

/// <summary>
/// A simple generic queue implemented as a singly-linked list.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
public class Queue<T>
{
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
    public int count;

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
    /// Gets the number of elements in the queue.
    /// </summary>
    /// <returns>The current element count.</returns>
    public int Count()
    {
        return count;
    }
}