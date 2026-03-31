using System;

abstract class Base 
{
    public string name = "";

    public override string ToString()
    {
        return "" + name + " is a " + GetType();
    }
}

interface IInteractive
{
    void Interact()
    {
        
    }
}

interface IBreakable
{
    public int durability { get; set; }
    void Break()
    {
        
    }
}

interface ICollectable
{
    public bool isCollected { get; set; }

    void Collect()
    {
        
    }
}

class TestObject : Base, ICollectable, IBreakable, IInteractive
{
    public bool isCollected { get; set; }
    public int durability { get; set; }
}
