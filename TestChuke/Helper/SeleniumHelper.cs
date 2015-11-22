using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace TestChuke
{
    public class SeleniumHelper
    {
        private IWebDriver _driver;

        public  SeleniumHelper(IWebDriver driver) 
        {
            _driver = driver;
        }

        private string WebsiteUrl
        {
            get { return ConfigurationManager.AppSettings["WebsiteUrl"]; }
        }


        public void Input(By by, string userName)
        {
            WaitElement( by);
            _driver.FindElement(by).Clear();
            _driver.FindElement(by).SendKeys(userName);
        }

        public void WaitElement(By by)
        {
            var wd = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            wd.Until(d => d.FindElement(@by).Displayed);
        }

       

        internal void ClickElement(By by)
        {
            WaitElement(by);
            _driver.FindElement(by).Click();
        }

        public string GetPageTitle()
        {
            return _driver.Title;
        }

        public void OpenPage(string WebsiteUrl)
        {
            _driver.Navigate().GoToUrl(WebsiteUrl);
        }

        public void AssertElementExist(By by)
        {
            try
            {
                _driver.FindElement(by);
            }
            catch (NoSuchElementException e)
            {
                throw e;
            }

        }
    }
}
