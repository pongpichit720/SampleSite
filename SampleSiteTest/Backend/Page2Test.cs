using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleSite.Backend;

namespace SampleSiteTest.Backend
{
    [TestClass]
    public class Page2Test
    {
        [TestMethod]
        public void GetColorTest()
        {
            Page2 page2 = new Page2();
            Assert.AreEqual(page2.GetColor(), "blueviolet");
        }

        [TestMethod]
        public void GetDesciptionTest()
        {
            Page2 page2 = new Page2();
            Assert.AreEqual(page2.GetDescription(), "information");
        }

        [TestMethod]
        public void GetLabelTest()
        {
            Page2 page2 = new Page2();
            Assert.AreEqual(page2.GetLabel(), "Page_2");
        }

        [TestMethod]
        public void GetDataTest()
        {
            Page2 page2 = new Page2();
            string[][] data = page2.GetData();
            string[][] expected = {
               new string[] { "John", "Doe", "25"  },
               new string[] { "Jane", "Doe", "50"  },
               new string[] { "Jim",  "Doe", "75"  },
               new string[] { "Joy",  "Doe", "100" },
            };
            Assert.AreEqual(data.ToString(), expected.ToString());
        }
    }
}
