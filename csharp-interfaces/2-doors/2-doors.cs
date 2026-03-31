using System;

abstract class Base 
{
    string name { get; set; }

    public override string ToString()
    {
        return "" + name + " is a " + GetType();
    }
}

interface IInteractive
{
    void Interact();
}

interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

class Door : Base, IInteractive
{
    public Door (string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine("You try to open the " + this.name + ". It's locked.");
    }
}
