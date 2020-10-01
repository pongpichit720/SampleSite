using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleSite.Controllers;
using System.Diagnostics;

namespace SampleSiteTest.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        public static HomeController myController;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            myController = new HomeController(null);
        }

        [TestMethod]
        public void IndexTest()
        {
            Assert.IsNotNull(myController.Index());
        }

        [TestMethod]
        public void PrivacyTest()
        {
            Assert.IsNotNull(myController.Privacy());
        }

        [TestMethod]
        public void Page1Test()
        {
            Assert.IsNotNull(myController.Page1());
        }

        [TestMethod]
        public void Page2Test()
        {
            Assert.IsNotNull(myController.Page2());
        }

        [TestMethod]
        public void Page3Test()
        {
            Assert.IsNotNull(myController.Page3());
        }

        [TestMethod]
        public void Page4Test()
        {
            Assert.IsNotNull(myController.Page4());
        }

        [TestMethod]
        public void ErrorTest()
        {
            Activity activity = new Activity("test");
            activity.Start();

            var result = myController.Error() as ViewResult;

            activity.Stop();

            Assert.AreEqual("SampleSite.Models.ErrorViewModel", result.Model.ToString());
        }
    }
}
