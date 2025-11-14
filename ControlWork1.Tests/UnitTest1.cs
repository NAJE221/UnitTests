using System;
using NUnit.Framework;
using ControlWork1;

namespace ControlWork1.Tests;

[TestFixture]
public class Task1Tests
{
    [Test]
    public void CheckingForNull()
    {
        int[] nums = null;
        Assert.Throws<ArgumentNullException>(() => Task1.Sort(nums));
    }

    [Test]
    public void CheckingForAnEmptyString()
    {
        int[] nums = new int[0];
        Assert.Throws<ArgumentException>(() => Task1.Sort(nums));
    }

    [Test]
    public void SortingCheck1()
    {
        int[] nums = { 1, 4, 5, 2 };
        Task1.Sort(nums);
        Assert.AreEqual(new int[] {1,2,4,5},nums);
    }

    [Test]
    public void SortingCheck2()
    {
        int[] nums = { 1, 6, 8, 9 };
        Task1.Sort(nums);
        Assert.AreEqual(new int[] {1,6,8,9}, nums);
    }

    [Test]
    public void SortingCheck3()
    {
        int[] nums = { 1 };
        Task1.Sort(nums);
        Assert.AreEqual(new int[]{1},nums);
    }

    [Test]
    public void CheckingSortingOnNegativeNumbers()
    {
        int[] nums = { -1, -3, -2 };
        Task1.Sort(nums);
        Assert.AreEqual(new int[] {-3,-2,-1}, nums);
    }
}