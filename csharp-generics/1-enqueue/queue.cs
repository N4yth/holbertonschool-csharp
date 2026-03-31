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
        public object value = null;
        public Node next = null;

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
        if (head == null)
        {
            head.next = value;
            tail = value;
            count ++;
        }
        else
        {
            Node tmp = head.next;
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
