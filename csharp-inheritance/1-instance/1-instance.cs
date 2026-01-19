using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}