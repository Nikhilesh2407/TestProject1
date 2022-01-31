using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.arm.com/");
            Driver.Manage().Window.Maximize();  
        }

        [Test]
        public void Test1()
        {
            string Gettitle;
            Gettitle = Driver.Title;
            Assert.AreEqual("Artificial Intelligence Enhanced Computing – Arm®", Gettitle);
        }
        [Test]
        public void Test2()
        {
            string Gettitle;
            Gettitle = Driver.Title;
            Assert.AreEqual("Intelligence Enhanced Computing – Arm®", Gettitle);
        }
    }
}