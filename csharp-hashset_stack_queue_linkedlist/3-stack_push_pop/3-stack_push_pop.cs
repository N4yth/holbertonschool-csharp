using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        string remove = "";
        int nbele = 0;
        foreach (var item in aStack)
        {
            nbele++;
        }
        Console.WriteLine($"Number of items: {nbele}");
        if (nbele == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"Top item: {aStack.Peek()}");
        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");
        if (aStack.Contains(search))
        {
            while (remove != search)
            {
                remove = aStack.Pop();
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}