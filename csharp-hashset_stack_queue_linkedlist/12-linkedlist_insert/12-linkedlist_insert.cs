using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current;

        current = myLList.First;
        while (current != null)
        {
            if ((current.Value > n && current.Next != null) || (current.Value > n && current.Next == null))
            {
                myLList.AddBefore(current, n);
                break;
            }
            else if (current.Value < n && current.Next == null)
            {
                myLList.AddAfter(current, n);
                break;
            }
            current = current.Next;
        }
        return current;
    }
}