using System;
using System.Globalization;
using Microsoft.VisualBasic;

class Queue<T>
{
    Node head;
    Node tail;
    int count;

    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        object value = null;
        Node next = null;

        public Node(Node value)
        {
            count = 0;
            next = value;
            head = value;
            tail = value;
        }
    }
    public void Enqueue(Node value)
    {
        if (next == null)
        {
            next = value;
            tail = value;
            count ++;
        }
        else
        {
            Node tmp = next;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            tmp.value = value;
            tail = value;
            count++;
        }
    }

    public int Count()
    {
        return count;
    }
}
