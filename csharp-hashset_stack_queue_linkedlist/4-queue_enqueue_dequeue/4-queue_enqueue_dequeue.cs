using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        string remove = "";
        int nbele = 0;
        foreach (var item in aQueue)
        {
            nbele++;
        }
        Console.WriteLine($"Number of items: {nbele}");
        if (nbele == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine($"First item: {aQueue.Dequeue()}");
        aQueue.Enqueue(newItem);
        Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");
        if (aQueue.Contains(search))
        {
            while (remove != search)
            {
                remove = aQueue.Dequeue();
            }
        }
        return aQueue;
    }
}