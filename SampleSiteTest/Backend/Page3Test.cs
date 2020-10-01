using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleSite.Backend;

namespace SampleSiteTest.Backend
{
    [TestClass]
    public class Page3Test
    {
        [TestMethod]
        public void GetColorTest()
        {
            Page3 page3 = new Page3();
            Assert.AreEqual(page3.GetColor(), "royalblue");
        }

        [TestMethod]
        public void GetDesciptionTest()
        {
            Page3 page3 = new Page3();
            Assert.AreEqual(page3.GetDescription(), "contact us");
        }

        [TestMethod]
        public void GetLabelTest()
        {
            Page3 page3 = new Page3();
            Assert.AreEqual(page3.GetLabel(), "Page_3");
        }
    }
}
