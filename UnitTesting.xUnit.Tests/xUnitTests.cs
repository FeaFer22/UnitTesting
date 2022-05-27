using Xunit;

namespace UnitTesting.xUnit.Tests
{
    public class xUnitTests
    {
        int x, y, Expected, Actual;
        [Fact]
        public void Sum_8and6_14returned()
        {
            x = 8;
            y = 6;
            Expected = 14;

            UnitTesting unitTesting = new UnitTesting();
            Actual = unitTesting.Sum(x, y);

            Assert.Equal(Expected, Actual);
        }
    }
}
