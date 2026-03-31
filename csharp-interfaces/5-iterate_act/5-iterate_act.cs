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
    public int durability { get; set; }

    public Decoration (string name = "Decoration", int durability = 1,  bool isQuestItem = false)
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
        this.durability -= 1;
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
    }
}

class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key (string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (!this.isCollected)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the " + this.name + ".");
        }
        else
        {
            Console.WriteLine("You have already picked up the " + this.name + ".");
        } 
    }
}

class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base obj in roomObjects)
        {
            if (type == typeof(IInteractive) && obj is IInteractive interactive)
            {
                interactive.Interact();
            }
            else if (type == typeof(IBreakable) && obj is IBreakable breakable)
            {
                breakable.Break();
            }
            else if (type == typeof(ICollectable) && obj is ICollectable collectable)
            {
                collectable.Collect();
            }
        }
    }
}
