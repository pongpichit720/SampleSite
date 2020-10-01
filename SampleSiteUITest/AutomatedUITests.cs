using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO.Compression;

namespace SampleSiteUITest
{
    [TestClass]
    public class AutomatedUITests
    {

        private readonly IWebDriver _driver;

        public AutomatedUITests()
        {
            _driver = new ChromeDriver();
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [TestMethod]
        public void NavagationTest()
        {
            _driver.Navigate().GoToUrl("https://localhost:44367/Home");
            Assert.AreEqual(_driver.Title, "Home Page - SampleSite");
            _driver.Navigate().GoToUrl("https://localhost:44367/Home/Page1");
            Assert.AreEqual(_driver.Title, "Page 1 - SampleSite");
            _driver.Navigate().GoToUrl("https://localhost:44367/Home/Page2");
            Assert.AreEqual(_driver.Title, "Page 2 - SampleSite");
            _driver.Navigate().GoToUrl("https://localhost:44367/Home/Page3");
            Assert.AreEqual(_driver.Title, "Page 3 - SampleSite");
            _driver.Navigate().GoToUrl("https://localhost:44367/Home/Page4");
            Assert.AreEqual(_driver.Title, "Page 4 - SampleSite");
            Dispose();
        }

        [TestMethod]
        public void NavHeaderTest()
        {
            _driver.Navigate().GoToUrl("https://localhost:44367/Home");
            Assert.AreEqual(_driver.Title, "Home Page - SampleSite");
            _driver.FindElement(By.Id("NavHeaderPage1")).Click();
            Assert.AreEqual(_driver.Title, "Page 1 - SampleSite");
            _driver.FindElement(By.Id("NavHeaderPage2")).Click();
            Assert.AreEqual(_driver.Title, "Page 2 - SampleSite");
            _driver.FindElement(By.Id("NavHeaderPage3")).Click();
            Assert.AreEqual(_driver.Title, "Page 3 - SampleSite");
            _driver.FindElement(By.Id("NavHeaderPage4")).Click();
            Assert.AreEqual(_driver.Title, "Page 4 - SampleSite");
            _driver.FindElement(By.Id("NavHeaderHome")).Click();
            Assert.AreEqual(_driver.Title, "Home Page - SampleSite");
            Dispose();
        }

        [TestMethod]
        public void NavFooterTest()
        {
            _driver.Navigate().GoToUrl("https://localhost:44367/Home");
            Assert.AreEqual(_driver.Title, "Home Page - SampleSite");
            _driver.FindElement(By.Id("NavFooterPage1")).Click();
            Assert.AreEqual(_driver.Title, "Page 1 - SampleSite");
            _driver.FindElement(By.Id("NavFooterPage2")).Click();
            Assert.AreEqual(_driver.Title, "Page 2 - SampleSite");
            _driver.FindElement(By.Id("NavFooterPage3")).Click();
            Assert.AreEqual(_driver.Title, "Page 3 - SampleSite");
            _driver.FindElement(By.Id("NavFooterPage4")).Click();
            Assert.AreEqual(_driver.Title, "Page 4 - SampleSite");
            Dispose();
        }

        [TestMethod]
        public void HomePageTest()
        {
            _driver.Navigate().GoToUrl("https://localhost:44367/Home");
            Assert.AreEqual(_driver.Title, "Home Page - SampleSite");
            _driver.FindElement(By.Id("Page1Btn")).Click();
            Assert.AreEqual(_driver.Title, "Page 1 - SampleSite");
            _driver.Navigate().GoToUrl("https://localhost:44367/Home");
            _driver.FindElement(By.Id("Page2Btn")).Click();
            Assert.AreEqual(_driver.Title, "Page 2 - SampleSite");
            _driver.Navigate().GoToUrl("https://localhost:44367/Home");
            _driver.FindElement(By.Id("Page3Btn")).Click();
            Assert.AreEqual(_driver.Title, "Page 3 - SampleSite");
            _driver.Navigate().GoToUrl("https://localhost:44367/Home");
            _driver.FindElement(By.Id("Page4Btn")).Click();
            Assert.AreEqual(_driver.Title, "Page 4 - SampleSite");
            Dispose();
        }

        [TestMethod]
        public void Page3Test()
        {
            _driver.Navigate().GoToUrl("https://localhost:44367/Home/Page3");
            Assert.AreEqual(_driver.Title, "Page 3 - SampleSite");
            _driver.FindElement(By.Id("SendBtn")).Click();
            Assert.AreEqual(_driver.FindElement(By.Id("ReplyText")).GetAttribute("innerHTML"), "missing sender");
            _driver.FindElement(By.Id("FromInput")).SendKeys("sender");
            _driver.FindElement(By.Id("SendBtn")).Click();
            Assert.AreEqual(_driver.FindElement(By.Id("ReplyText")).GetAttribute("innerHTML"), "missing subject");
            _driver.FindElement(By.Id("SubjectInput")).SendKeys("subject");
            _driver.FindElement(By.Id("SendBtn")).Click();
            Assert.AreEqual(_driver.FindElement(By.Id("ReplyText")).GetAttribute("innerHTML"), "missing message");
            _driver.FindElement(By.Id("MessageInput")).SendKeys("message");
            _driver.FindElement(By.Id("SendBtn")).Click();
            Assert.AreEqual(_driver.FindElement(By.Id("ReplyText")).GetAttribute("innerHTML"), "Got it. Will reply within 24 months.");
            Dispose();
        }
    }
}
