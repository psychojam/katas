using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Step1_Algo.Tests
{
    [TestClass]
    public class Leap
    {
        [TestMethod]
        public void Year_2001_is_not_leap_year()
        {
            var isLeap = Step1_Algo.Leap.IsLeapYear(2001);
            Assert.IsFalse(isLeap);
        }

        [TestMethod]
        public void Year_2016_is_leap_year()
        {
            var isLeap = Step1_Algo.Leap.IsLeapYear(2016);
            Assert.IsTrue(isLeap);
        }
    }
}
