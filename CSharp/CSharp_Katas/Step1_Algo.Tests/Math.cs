using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Step1_Algo.Tests
{
    [TestClass]
    public class Math
    {
        [TestMethod]
        public void Number_6_is_not_odd_number()
        {
            var isOdd = Step1_Algo.Math.IsOdd(6);
            Assert.IsFalse(isOdd);
        }

        [TestMethod]
        public void Number_5_is_odd_number()
        {
            var isOdd = Step1_Algo.Math.IsOdd(5);
            Assert.IsTrue(isOdd);
        }

    }
}
