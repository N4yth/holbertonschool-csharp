using System.Runtime.CompilerServices;
using NUnit.Framework;
using MyMath;

public class Tests
{
    [Test]
    public void Add_TwoPositif()
    {
        var result = Operations.Add(1, 2);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Add_Twonegatif()
    {
        var result = Operations.Add(-1, -2);
        Assert.That(result, Is.EqualTo(-3));
    }

    [Test]
    public void Add_PositifAndNegatif()
    {
        var result = Operations.Add(-1, 2);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Add_TwoZero()
    {
        var result = Operations.Add(0, 0);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Add_OneZero()
    {
        var result = Operations.Add(0, 2);
        Assert.That(result, Is.EqualTo(2));
    }
}