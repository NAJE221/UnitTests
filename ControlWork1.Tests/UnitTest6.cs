using ControlWork1;
using System;
using NUnit.Framework;

[TestFixture]
public class UnitTest6
{
    [Test]
    public void CheckingThatTheStringIsNull()
    {
        int number;
        string str = null;
        Assert.Throws<ArgumentNullException>(()=>Task6.TryParse1(str,out number));
    }

    [Test]
    public void CheckingForAnEmptyString()
    {
        int number;
        string str = string.Empty;
        Assert.Throws<ArgumentException>(() => Task6.TryParse1(str, out number));
    }

    [Test]
    public void CheckingThatTheInputIsNotANumber1()
    {
        int number;
        string str = "abc";
        Assert.IsFalse(Task6.TryParse1(str, out number));
        Assert.AreEqual(0, number);
    }
    
    [Test]
    public void CheckingThatTheInputIsNotANumber2()
    {
        int number;
        string str = "Hello World";
        Assert.IsFalse(Task6.TryParse1(str, out number));
        Assert.AreEqual(0, number);
    }
    
    [Test]
    public void CheckingThatTheInputIsNotANumber3()
    {
        int number;
        string str = "123 123";
        Assert.IsFalse(Task6.TryParse1(str, out number));
        Assert.AreEqual(0, number);
    }

    [Test]
    public void CheckingThatANumberIsBeingSupplied1()
    {
        int number;
        string str = "123";
        Assert.IsTrue(Task6.TryParse1(str, out number));
        Assert.AreEqual(123, number);
    }
    
    [Test]
    public void CheckingThatANumberIsBeingSupplied2()
    {
        int number;
        string str = "-12309764";
        Assert.IsTrue(Task6.TryParse1(str, out number));
        Assert.AreEqual(-12309764, number);
    }
}
