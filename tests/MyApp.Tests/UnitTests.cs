using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp;

namespace MyApp.Tests;

[TestClass]
[TestCategory("Unit")]
public class UnitTests
{
    private Calculator _calculator = new();

    [TestMethod]
    [TestCategory("Unit")]
    public void Add_TwoNumbers_ReturnsSum()
    {
        TestContext.WriteLine("Testing addition of 2 + 3");
        var result = _calculator.Add(2, 3);
        Assert.AreEqual(5, result);
        TestContext.WriteLine($"Result: {result}");
    }

    [TestMethod]
    [TestCategory("Unit")]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        TestContext.WriteLine("Testing subtraction of 5 - 3");
        var result = _calculator.Subtract(5, 3);
        Assert.AreEqual(2, result);
        TestContext.WriteLine($"Result: {result}");
    }

    public TestContext TestContext { get; set; } = null!;
}
