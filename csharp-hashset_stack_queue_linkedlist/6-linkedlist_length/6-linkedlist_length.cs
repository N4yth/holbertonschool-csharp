using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int nbele = 0;
        foreach(var i in myLList) 
            nbele++;
        return nbele;
    }
}