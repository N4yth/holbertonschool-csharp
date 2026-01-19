using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType().Equals(typeof(int)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}