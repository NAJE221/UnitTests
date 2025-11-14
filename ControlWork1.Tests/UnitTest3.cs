using System.Globalization;
using NUnit.Framework;
using ControlWork1;

namespace ControlWork1.Tests;

[TestFixture]
public class Task3Tests
{
    [Test]
    public void CheckingForNull()
    {
        string s = null;
        Assert.Throws<ArgumentNullException>(() => Task3.Position(s));
    }

    [Test]
    public void CheckingForAnEmptyString()
    {
        string s = string.Empty;
        Assert.Throws<ArgumentException>(() => Task3.Position(s));
    }

    [Test]
    public void CheckingForLineBreaks()
    {
        string s = "AB";
        Assert.Throws<ArgumentException>(() => Task3.Position(s));
    }

    [Test]
    public void CheckingForThe3rdElementFromTheEnd1()
    {
        string s = "ABC";
        Assert.AreEqual('A', Task3.Position(s));
    }

    [Test]
    public void CheckingForThe3rdElementFromTheEnd2()
    {
        string s = "ABCDDDD!@#$123";
        Assert.AreEqual('1', Task3.Position(s));
    }
}