using System.Runtime.CompilerServices;
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
    public void Add_pisitifAndNegatif()
    {
        var result = Operations.Add(-1, 2);
        Assert.That(result, Is.EqualTo(1));
    }
}