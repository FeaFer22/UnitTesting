using NUnit.Framework;

namespace UnitTesting.NUnit.Tests
{
    [TestFixture]
    public class NUnitTests
    {
        UnitTesting unitTesting;
        int x, y, Expected, Actual;

        [SetUp]
        public void Setup()
        {
            unitTesting = new UnitTesting();
        }

        [Test]
        public void Sum_15and7_22returned()
        {
            x = 15;
            y = 7;
            Expected = 22;
            Actual = unitTesting.Sum(x, y);
            Assert.AreEqual(Expected, Actual);
        }
    }
}