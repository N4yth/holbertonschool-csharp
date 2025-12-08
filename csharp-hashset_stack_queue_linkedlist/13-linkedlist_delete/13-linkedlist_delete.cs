using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current;
        int idx = 0;
        current = myLList.First;
        while (current != null)
        {
            if (index == idx)
            {
                myLList.Remove(current);
                break;
            }
            idx++;
            current = current.Next;
        }
    }
}