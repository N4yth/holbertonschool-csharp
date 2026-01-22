# Why a Square Should Not Inherit from a Rectangle

### A Practical Explanation of the Liskov Substitution Principle

At first glance, it seems obvious that a Square is a Rectangle. After all, both have four sides and right angles, and a square even satisfies the mathematical definition of a rectangle.

However, when we try to model this relationship in object-oriented programming, especially in languages like C#, this seemingly logical inheritance can lead to subtle but serious design problems. In fact, it violates one of the most important principles of object-oriented design: the Liskov Substitution Principle (LSP).

Let’s explore why.

---

## What Is the Liskov Substitution Principle?

The Liskov Substitution Principle, introduced by Barbara Liskov, states:

> *Objects of a derived class must be substitutable for objects of their base class without altering the correctness of the program.*

In simpler terms:

If a class `B` inherits from class `A`, then anywhere we use `A`, we should be able to use `B` without unexpected behavior.

Inheritance is not just about sharing properties — it’s about honoring behavioral contracts.

---

## The Rectangle–Square Problem in Code

Consider a typical `Rectangle` class:

```csharp
class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int Area()
    {
        return Width * Height;
    }
}
```

Now let’s implement `Square` by inheriting from `Rectangle`:

```csharp
class Square : Rectangle
{
    public override int Width
    {
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height
    {
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public int Size
    {
        get { return Width; }
        set
        {
            Width = value;
            Height = value;
        }
    }
}
```

At first, this looks reasonable. A square must keep width and height equal, so we override the setters.

But now consider this code:

```csharp
Square aSquare = new Square();
aSquare.Width = 12;
aSquare.Height = 8;

Console.WriteLine(aSquare.Width);   // ?
Console.WriteLine(aSquare.Height);  // ?
```

### What happens?

* Setting `Width = 12` forces `Height = 12`
* Setting `Height = 8` forces `Width = 8`

The final state is 8 × 8, not 12 × 8.

This behavior breaks expectations established by `Rectangle`.

---

## Why This Violates Liskov Substitution

A `Rectangle` promises this behavior:

> *Width and Height can be changed independently.*

A `Square` cannot honor that contract.

So if a function expects a `Rectangle` and modifies width and height independently, substituting a `Square` will silently change behavior — and possibly introduce bugs.

That is a direct violation of LSP.

---

## Why Square Inheriting from Rectangle Is a Bad Design Choice

The issue isn’t mathematical — it’s behavioral.

* A rectangle allows independent dimensions
* A square enforces equal dimensions
* Inheritance implies “is-a and behaves-like”
* Square is-a rectangle, but does not behave like one

This mismatch leads to:

* Hidden side effects
* Broken assumptions
* Fragile code
* Violations of SOLID principles

---

## A Better Class Hierarchy

The solution is to rethink the inheritance model.

### Correct Design: Shared Abstraction

Instead of `Square` inheriting from `Rectangle`, both should inherit from a common base class, such as `Shape`.

```csharp
abstract class Shape
{
    public abstract int Area();
}
```

```csharp
class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int Area()
    {
        return Width * Height;
    }
}
```

```csharp
class Square : Shape
{
    public int Size { get; set; }

    public override int Area()
    {
        return Size * Size;
    }
}
```

### Benefits of This Approach

- No broken contracts
- No surprising side effects
- LSP is preserved
- Cleaner, more maintainable code
- Easier future extensions

---

## Key Takeaways

* Inheritance is about behavior, not just shared properties
* Violating LSP often leads to subtle bugs
* Mathematical relationships don’t always translate to good OO design
* Favor composition or shared abstractions over forced inheritance

The Rectangle–Square problem is a classic reminder that good design is about correctness, not convenience.
