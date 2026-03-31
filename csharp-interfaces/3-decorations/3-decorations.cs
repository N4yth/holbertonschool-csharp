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

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;

    public Door (string name = "Door", int durability = 1,  bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.durability = durability;
        this.name = name;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine("The " + this.name + " has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine("You look at the " + this.name + ". There's a key inside.");
        }
        else
        {
            Console.WriteLine("You look at the " + this.name + ". Not much to see here.");
        }
    }

    public void Break()
    {
        if (this.durability > 0)
        {
            Console.WriteLine("You hit the " + this.name + ". It cracks.");
        }
        else if (this.durability == 0)
        {
            Console.WriteLine("You smash the " + this.name + ". What a mess.");
        }
        else
        {
            Console.WriteLine("The " + this.name + " is already broken.");
        }
        this.durability = this.durability -1;
    }
}
