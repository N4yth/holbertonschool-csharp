using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        string[] tmparray = new string[myDict.Count];
        int i = 0;
        foreach (KeyValuePair<string, string> Entry in myDict.OrderBy(x => x.Key))
        {
            tmparray[i] = Entry.Key;
            i++;
        }
        Array.Sort(tmparray);
        foreach (string item in tmparray)
        {
            Console.WriteLine($"{item}: {myDict[item]}");
        }
    }
}