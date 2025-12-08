using System;
using System.Collections.Generic;

class List
{
    // Main - entry point
    public static int Sum(List<int> myList)
    {
        int result = 0;
        HashSet<int> hash = new HashSet<int>();
        foreach (var item in myList)
        {
            hash.Add(item);
        }
        foreach (var item in hash)
        {
            result += item;
        }
        return result;
    }
}