using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        Dictionary<string, string> newDict = new Dictionary<string, string>();

        newDict = myDict;
        foreach (KeyValuePair<string, string> Entry in myDict.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{Entry.Key}: {Entry.Value}");
        }
    }
}