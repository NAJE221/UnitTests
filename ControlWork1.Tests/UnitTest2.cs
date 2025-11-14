using System.Globalization;
using NUnit.Framework;
using ControlWork1;

namespace ControlWork1.Tests;

[TestFixture]
public class Task2Tests
{
    [Test]
    public void CheckingForNull()
    {
        string lower = null;
        Assert.Throws<ArgumentNullException>(() => Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForAnEmptyString()
    {
        string lower = string.Empty;
        Assert.Throws<ArgumentException>(() => Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForTheNumberOfSmallLetters1()
    {
        string lower = "a";
        Assert.AreEqual(1, Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForTheNumberOfSmallLetters2()
    {
        string lower = "A";
        Assert.AreEqual(0, Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForTheNumberOfSmallLetters3()
    {
        string lower = "abcABC";
        Assert.AreEqual(3, Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForTheNumberOfSmallLetters4()
    {
        string lower = "abcABCadafafgatqetrqfadsgsughndagiosdmhidsb1o1";
        Assert.AreEqual(41, Task2.IsLower(lower));
    }
}