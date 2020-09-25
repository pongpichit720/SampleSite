using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleSite;

namespace SampleSiteTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Temporary temp = new Temporary();
            Assert.AreEqual(temp.Name, "HELLO WORLD!!!");

            temp.Name = "ABC";
            Assert.AreEqual(temp.Name, "ABC");
        }
    }
}
