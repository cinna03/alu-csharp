using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        if (aQueue == null)
            aQueue = new Queue<string>();

        // Number of items
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // First item
        if (aQueue.Count > 0)
            Console.WriteLine($"First item: {aQueue.Peek()}");
        else
            Console.WriteLine("Queue is empty");

        // Check if contains search item
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        // Remove items up to and including search without using Dequeue in a loop
        if (containsSearch)
        {
            // Enumerate items from front to back
            List<string> itemsFrontToBack = new List<string>(aQueue);
            int idx = itemsFrontToBack.IndexOf(search);

            // Keep items after the found index
            List<string> keep = new List<string>();
            if (idx >= 0)
            {
                for (int i = idx + 1; i < itemsFrontToBack.Count; i++)
                    keep.Add(itemsFrontToBack[i]);
            }
            else
            {
                keep = itemsFrontToBack;
            }

            // Rebuild the original queue with kept items
            aQueue.Clear();
            for (int i = 0; i < keep.Count; i++)
                aQueue.Enqueue(keep[i]);
        }

        // Add new item
        aQueue.Enqueue(newItem);

        return aQueue;
    }
}

