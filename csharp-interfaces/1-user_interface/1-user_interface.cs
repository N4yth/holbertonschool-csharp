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

class TestObject : Base, ICollectable, IBreakable, IInteractive
{
    public int durability { get; set; }
    public bool isCollected { get; set; }
    public string name { get; set; }

    public void Interact(){}
    public void Collect(){}
    public void Break(){}
}
