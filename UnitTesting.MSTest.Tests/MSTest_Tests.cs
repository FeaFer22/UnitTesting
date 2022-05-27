using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.MSTest.Tests
{
    [TestClass]
    public class MSTest_Tests
    {
        int x, y, Expected, Actual;
        [TestMethod]
        public void Sum_20and30_50returned()
        {
            x = 8;
            y = 6;
            Expected = 14;

            UnitTesting unitTesting = new UnitTesting();
            Actual = unitTesting.Sum(x, y);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
