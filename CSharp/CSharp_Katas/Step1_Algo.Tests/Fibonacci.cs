using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Step1_Algo.Tests
{
    [TestClass]
    public class Fibonacci
    {
        [TestMethod]
        public void The_1_position_of_Fibonacci_is_1()
        {
            var val = Step1_Algo.Fibonacci.Value(1);
            Assert.AreEqual(val, 1);
        }

        [TestMethod]
        public void The_3_position_of_Fibonacci_is_2()
        {
            var val = Step1_Algo.Fibonacci.Value(3);
            Assert.Equals(val, 2);
        }
    }
}
