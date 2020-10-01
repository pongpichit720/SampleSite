using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleSite.Models;

namespace SampleSiteTest.Models
{
    [TestClass]
    public class ErrorViewModelTest
    {
        [TestMethod]
        public void RequestIdTest()
        {
            ErrorViewModel myModel = new ErrorViewModel();
            Assert.IsNull(myModel.RequestId);
            myModel.RequestId = "id";
            Assert.AreEqual("id", myModel.RequestId);
        }

        [TestMethod]
        public void ShowRequestIdTest()
        {
            ErrorViewModel myModel = new ErrorViewModel();
            Assert.IsFalse(myModel.ShowRequestId);
            myModel.RequestId = "id";
            Assert.IsTrue(myModel.ShowRequestId);
        }

    }
}
