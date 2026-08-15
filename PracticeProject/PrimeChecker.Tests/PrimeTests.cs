using NUnit.Framework;
using PracticeProject;

namespace PrimeChecker.Tests;

[TestFixture]
public class PrimeTests
{
    private Prime prime;

    [SetUp]
    public void Setup()
    {
        prime = new Prime();
    }

    [Test]
    public void IsPrime_WhenNumberIsPrime_ReturnsTrue()
    {
        bool result = prime.IsPrime(7);

        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPrime_WhenNumberIsNotPrime_ReturnsFalse()
    {
        bool result = prime.IsPrime(8);

        Assert.That(result, Is.False);
    }

    [Test]
    public void IsPrime_WhenNumberIsOne_ReturnsFalse()
    {
        bool result = prime.IsPrime(1);

        Assert.That(result, Is.False);
    }

    [Test]
    public void IsPrime_WhenNumberIsNegative_ReturnsFalse()
    {
        bool result = prime.IsPrime(-5);

        Assert.That(result, Is.False);
    }

    [Test]
    public void IsPrime_WhenNumberIsTwo_ReturnsTrue()
    {
        bool result = prime.IsPrime(2);

        Assert.That(result, Is.True);
    }
}