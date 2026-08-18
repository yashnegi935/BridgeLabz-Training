namespace Calculator.Tests;
using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    public Calculator _calculator;

    [SetUp]
    public void setUp()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void addCheck()
    {
        int result = _calculator.Add(12, 20);
        Assert.That(result,NUnit.Framework.Is.EqualTo(32));
    }

    [TestCase(2, 3, 5)]
    [TestCase(10, 20, 30)]
    [TestCase(11, 11, 22)]
    public void addMultiple(int a , int b , int exp)
    {
        int res = a + b;
        Assert.That(res,Is.EqualTo(exp));
    }

    [TearDown]
    public void teardown()
    {
        Console.WriteLine("All testes finished");
    }
    
}