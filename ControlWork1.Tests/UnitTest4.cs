using System.Globalization;
using NUnit.Framework;
using ControlWork1;

namespace ControlWork1.Tests;

[TestFixture]
public class Task4Tests
{
    [Test]
    public void CheckingThatTheArgumentIsAPalindrome1()
    {
        int result = 121;
        Assert.IsTrue(Task4.IsPalindrome(result));
    }
    
    [Test]
    public void CheckingThatTheArgumentIsAPalindrome2()
    {
        int result = 1001;
        Assert.IsTrue(Task4.IsPalindrome(result));
    }

    [Test]
    public void CheckingThatTheArgumentIsNotAPalindrome1()
    {
        int result = 122;
        Assert.IsFalse(Task4.IsPalindrome(result));
    }
    
    [Test]
    public void CheckingThatTheArgumentIsNotAPalindrome2()
    {
        int result = 1000;
        Assert.IsFalse(Task4.IsPalindrome(result));
    }

    [Test]
    public static void CheckingЕoSeeIfASingleDigitReturnsTrue()
    {
        int result = 4;
        Assert.IsTrue(Task4.IsPalindrome(result));
    }
    
    [Test]
    public static void TheTestIsThatTheNumberIsNegative()
    {
        int result = -4;
        Assert.IsFalse(Task4.IsPalindrome(result));
    }
    
    // Нет, отрицательные числа не могут быть палиндромами. 
}