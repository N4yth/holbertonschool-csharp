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

    public object Dequeue()
    {
        if (head == null)
        {
           Console.WriteLine("Queue is empty");
           return default(T);
        }
        else
        {
            Node tmp = head;
            head = tmp.next;
            count--;
            return tmp.value;
        }
    }

    public object Peek()
    {
        if (head == null)
        {
           Console.WriteLine("Queue is empty");
           return default(T);
        }
        else
        {
            return head.value;
        }
    }

    public void Print()
    {
        if (head == null)
        {
           Console.WriteLine("Queue is empty");
        }
        else
        {
            Node tmp = head;
            while (tmp.next != null)
            {
                Console.WriteLine(tmp.value);
                tmp = tmp.next;
            }
            Console.WriteLine(tmp.value);
        }
    }

    public string Concatenate()
    {
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
           Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
           return null;
        }

        if (head == null)
        {
           Console.WriteLine("Queue is empty");
           return null;
        }
        else
        {
            string result ="";
            Node tmp = head;
            while (tmp.next != null)
            {
                result += tmp.value;
                if (typeof(T) == typeof(string))
                {
                    result += " ";
                }
                tmp = tmp.next;
            }
            result += tmp.value;
            return result;
        }
    }

    public int Count()
    {
        return count;
    }
}
