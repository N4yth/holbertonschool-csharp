using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int result = 0;
        foreach(int item in myLList) { 
            result += item;
        }
        return result;
    }
}