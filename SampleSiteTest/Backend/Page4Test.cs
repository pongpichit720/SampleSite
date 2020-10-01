using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleSite.Backend;

namespace SampleSiteTest.Backend
{
    [TestClass]
    public class Page4Test
    {
        [TestMethod]
        public void GetColorTest()
        {
            Page4 page4 = new Page4();
            Assert.AreEqual(page4.GetColor(), "seagreen");
        }

        [TestMethod]
        public void GetDesciptionTest()
        {
            Page4 page4 = new Page4();
            Assert.AreEqual(page4.GetDescription(), "something");
        }

        [TestMethod]
        public void GetLabelTest()
        {
            Page4 page4 = new Page4();
            Assert.AreEqual(page4.GetLabel(), "Page_4");
        }
    }
}
