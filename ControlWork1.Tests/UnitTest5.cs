using System.Globalization;
using NUnit.Framework;
using ControlWork1;

namespace ControlWork1.Tests;

[TestFixture]
public class Task5Tests
{
    [Test]
    public void CheckingWhetherAStringIsNull()
    {
        int[] nums = null;
        Assert.Throws<ArgumentNullException>(() => Task5.RunningSum(nums));
    }

    [Test]
    public void CheckingThatTheString()
    {
        int[] nums = new int [0];
        Assert.Throws<ArgumentException>(() => Task5.RunningSum(nums));
    }
    
    [Test]
    public void CheckingHowTheRunningSumMethodWorks1()
    {
        int[] nums = {0,3,14,8,2,94};
        Assert.AreEqual(new int[] {0,0,3,17,25,27}, Task5.RunningSum(nums));
    }
    [Test]
    public void CheckingHowTheRunningSumMethodWorks2()
    {
        int[] nums = { 1, 2, 3, 6 };
        Assert.AreEqual(new int[] {0,1,3,6}, Task5.RunningSum(nums));
    }
    [Test]
    public void TestingTheRunningSumMethodWithASingleArgument()
    {
        int[] nums = {1};
        Assert.AreEqual(new int[] {0}, Task5.RunningSum(nums));
    }
    
    [Test]
    public void TheSumWithNegativeNumbers()
    {
        int[] nums = {-1, -3, -5, -6};
        Assert.AreEqual(new int[] {0 ,-1 ,-4 ,-9}, Task5.RunningSum(nums));
    }
}