using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int size;
        foreach (var ele in myDict){
            size++;
        }
        return size;
    }
}