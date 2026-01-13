using System.Runtime.CompilerServices;
using NUnit.Framework;
using MyMath;

public class Tests
{
    [Test]
    public void Add_PositifNum()
    {
        int[,] matrix = {{ 2, 4 },{ 6, 8 }};
        int[,] expected = {{ 1, 2 },{ 3, 4 }};
        var result = Matrix.Divide(matrix, 2);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Add_NegatifNum()
    {
        int[,] matrix = {{ 2, 4 },{ 6, 8 }};
        int[,] expected = {{ -1, -2 },{ -3, -4 }};
        var result = Matrix.Divide(matrix, -2);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Add_ZeroNum()
    {
        int[,] matrix = {{ 2, 4 },{ 6, 8 }};
        var result = Matrix.Divide(matrix, 0);
        Assert.That(result, Is.EqualTo(null));
    }

    [Test]
    public void Add_NullMatrix()
    {
        var result = Matrix.Divide(null, 2);
        Assert.That(result, Is.EqualTo(null));
    }

    [Test]
    public void Add_NegatifMatrix()
    {
        int[,] matrix = {{ -2, -4 },{ -6, -8 }};
        int[,] expected = {{ -1, -2 },{ -3, -4 }};
        var result = Matrix.Divide(matrix, 2);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Add_AllNegatif()
    {
        int[,] matrix = {{ -2, -4 },{ -6, -8 }};
        int[,] expected = {{ 1, 2 },{ 3, 4 }};
        var result = Matrix.Divide(matrix, -2);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Add_AllZero()
    {
        var result = Matrix.Divide(null, 0);
        Assert.That(result, Is.EqualTo(null));
    }
}