using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLL = new LinkedList<int>();

        for (int i = 0 ; i < size ; i++)
        {
            Console.WriteLine($"{i}");
            newLL.AddLast(i);
        }
        return newLL;
    }
}