using System;

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

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    public int Count()
    {
        return count;
    }
}
