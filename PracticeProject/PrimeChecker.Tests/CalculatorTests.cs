using NUnit.Framework;
using PracticeProject;

namespace PrimeChecker.Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Divide_WhenNumbersAreValid_ReturnsQuotient()
    {
        int result = calculator.Divide(10, 2);

        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Divide_WhenDivisorIsZero_ThrowsArithmeticException()
    {
        Assert.Throws<ArithmeticException>(() =>
        {
            calculator.Divide(10, 0);
        });
    }
}