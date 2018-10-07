using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Step3_Framework
{
    [TestClass]
    public class Linq
    {
        #region sum Fixtures

        public struct Item
        {
            public string Label { get; set; }
            public int Total { get; set; }
        }

        public IList<Item> ItemsToSum => new List<Item>
        {
            new Item { Label = "Test 1", Total = 10 },
            new Item { Label = "Test 2", Total = 150 },
            new Item { Label = "Test 3", Total = 540 }
        };

        #endregion

        [TestMethod]
        public void Can_you_Sum_This()
        {
            // Sum ItemsToSum

            var sum = 0;
            var excepted = 700;

            Assert.AreEqual(excepted, sum);
        }

        [TestMethod]
        public void Remove_All_Uppercase_Characters()
        {
            string value = "AazazAZAZAZazazaz1154";

            string excepted = "azazazazaz1154";

            Assert.AreEqual(excepted, value);
        }

        [TestMethod]
        public void Take()
        {
            string value = "AazazAZAZAZazazaz1154";

            string excepted = "azazazazaz1154";

            Assert.AreEqual(excepted, value);
        }

        [TestMethod]
        public void OrderBy()
        {
            var myList = new List<string>()
            {
                "Hamid",
                "Bob",
                "Carl"
            };

            var excepted = new List<string>()
            {
                "Bob",
                "Carl",
                "Hamid"
            };

            Assert.AreEqual(excepted.First(), myList.First());
            Assert.AreEqual(excepted.Last(), myList.Last());
        }
    }
}

