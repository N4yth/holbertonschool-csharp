using System;

abstract class Base 
{
    public string name { get; set; }

    public override string ToString()
    {
        return "" + name + " is a " + GetType();
    }
}

interface IInteractive
{
    public void Interact();
}

interface ICollectable
{
    public bool isCollected { get; set; }

    public void Collect();
}

interface IBreakable
{
    public int durability { get; set; }
    public void Break();
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
