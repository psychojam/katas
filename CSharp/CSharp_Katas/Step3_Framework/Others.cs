using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Step3_Framework
{
    [TestClass]
    public class Others
    {  
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void manageException()
        {
            int salary = 2000000000;

            salary *= 20;

            Assert.Fail("Should have raised an OverflowException...");
        }

    }
}
