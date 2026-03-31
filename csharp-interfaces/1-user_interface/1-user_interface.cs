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

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

class TestObject : Base, ICollectable, IBreakable, IInteractive
{
    public bool isCollected { get; set; }
    public int durability { get; set; }
    public string name { get; set; }

    public void Collect(){}
    public void Interact(){}
    public void Break(){}
}
