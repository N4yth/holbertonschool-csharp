using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType().IsSubclassOf(Array) || obj.GetType() == Array)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}