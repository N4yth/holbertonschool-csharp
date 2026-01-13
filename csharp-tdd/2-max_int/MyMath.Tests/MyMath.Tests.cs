using System.Runtime.CompilerServices;
using NUnit.Framework;
using MyMath;

public class Tests
{
    [Test]
    public void Add_Positif()
    {
        var result = Operations.Max([1, 2 ,3]);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Add_negatif()
    {
        var result = Operations.Max([-1, -2 ,-3]);
        Assert.That(result, Is.EqualTo(-1));
    }

    public void Add_negatifandpositif()
    {
        var result = Operations.Max([-1, -2 ,-3, 1, 2, 3]);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Add_empty()
    {
        var result = Operations.Max([]);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Add_oneElement()
    {
        var result = Operations.Max([1]);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Add_AllZero()
    {
        var result = Operations.Max([0, 0, 0, 0]);
        Assert.That(result, Is.EqualTo(0));
    }
}