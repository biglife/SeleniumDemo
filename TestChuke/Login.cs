using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace TestChuke
{
    [TestClass]
    public class Login
    {

        private IWebDriver driver;
        private string baseURL;

        [TestInitialize]
        public void SetupTest() 
        {
            driver = new ChromeDriver();
            baseURL = "http://211.144.201.107:8080/";
        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public void waitElement(By by) 
        {
            var wd = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wd.Until(d => d.FindElement(@by).Displayed);
        }

        [TestMethod]
        public void LoginasAdmin()
        {
            driver.Navigate().GoToUrl(baseURL + "/#/");
            waitElement(By.Name("Account"));
            driver.FindElement(By.Name("Account")).Clear();
            driver.FindElement(By.Name("Account")).SendKeys("sysadmin");
            waitElement(By.Name("PWD"));
            driver.FindElement(By.Name("PWD")).Clear();
            driver.FindElement(By.Name("PWD")).SendKeys("abc123");
            Assert.AreEqual(driver.FindElement(By.XPath("//article[@id='Home']")).Displayed,true);
        }
    }
}
