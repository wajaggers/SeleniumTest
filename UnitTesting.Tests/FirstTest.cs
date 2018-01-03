using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTesting.Tests
{
    [TestFixture]
    public class FirstTest
    {
        private const string CHROME_DRIVER_PATH = @"C:\SeleniumDriver";

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void BillsSweetTest()
        {
            IWebDriver driver = new ChromeDriver(CHROME_DRIVER_PATH);
            driver.Navigate().GoToUrl("http://localhost:54381/");

            IWebElement checkBox = driver.FindElement(By.Id("cbBillCheckMe"));
            checkBox.Click();

            Assert.That(checkBox.Selected == true);
        }
    }
}
