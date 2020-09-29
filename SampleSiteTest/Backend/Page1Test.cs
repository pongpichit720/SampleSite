using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleSite.Backend;

namespace SampleSiteTest.Backend
{
    [TestClass]
    public class Page1Test
    {
        [TestMethod]
        public void GetColorTest()
        {
            Page1 page1 = new Page1();
            Assert.AreEqual(page1.GetColor(), "crimson");
        }

        [TestMethod]
        public void GetDesciptionTest()
        {
            Page1 page1 = new Page1();
            Assert.AreEqual(page1.GetDescription(), "pictures");
        }

        [TestMethod]
        public void GetLabelTest()
        {
            Page1 page1 = new Page1();
            Assert.AreEqual(page1.GetLabel(), "Page_1");
        }

        [TestMethod]
        public void GetImagesTest()
        {
            Page1 page1 = new Page1();
            string[] images = page1.GetImages();
            string[] expected = new string[] {
                "https://www.w3schools.com/css/img_lights.jpg",
                "https://www.w3schools.com/css/img_forest.jpg",
                "https://www.w3schools.com/css/img_5terre.jpg",
                "https://www.w3schools.com/css/img_mountains.jpg",
            };
            Assert.AreEqual(images.ToString(), expected.ToString());
        }
    }
}
