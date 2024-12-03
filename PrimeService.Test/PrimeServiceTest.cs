using Prime.Services;

namespace Prime.Test;

[TestClass]
public sealed class PrimeServiceTest
{
    [TestMethod]
    public void TestIsPrime_InputIs1_ReturnFalse()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(1);

        Assert.IsFalse(result, "1 should not be prime");
    }

    [TestMethod]
    public void TestIsPrime_InputIs2_ReturnFalse()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(2);

        Assert.IsFalse(result, "2 should not be prime");
    }
}
