using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Step1_Algo.Tests
{
    [TestClass]
    public class Math
    {
        // Odd
        [TestMethod]
        public void Number_6_is_not_odd_number()
        {
            var isLeap = Step1_Algo.Leap.IsLeapYear(6);
            Assert.IsFalse(isLeap);
        }

        [TestMethod]
        public void Number_5_is_odd_number()
        {
            var isLeap = Step1_Algo.Leap.IsLeapYear(5);
            Assert.IsTrue(isLeap);
        }

    }
}
