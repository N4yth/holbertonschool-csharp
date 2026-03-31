using System;
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
            next = value;
        }

        public void Enqueue(Node value)
        {
            if (next == null)
            {
                next = value;
            }
            else
            {
                Node tmp = next;
                while (tmp.next != null)
                {
                    tmp = tmp.next;
                }
                tmp.value = value;
            }
        }

        public int Count()
        {
            int nbNode = 0;
            Node tmp = next;
            while (tmp.next != null)
            {
                tmp = tmp.next;
                nbNode++;
            }
            return nbNode;
        }
    }
}
