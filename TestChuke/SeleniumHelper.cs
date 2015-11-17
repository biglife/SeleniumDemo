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
        public static string WebsiteUrl
        {
            get { return ConfigurationManager.AppSettings["WebsiteUrl"]; }
        }

        public static string Browser
        {
            get { return ConfigurationManager.AppSettings["Brower"]; }
        }

        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    if (Browser == "chrome")
                    {
                        _driver = new ChromeDriver();
                    }
                    else if (Browser == "ie")
                    {
                        _driver = new InternetExplorerDriver();
                    }
                    else
                    {
                        _driver = new FirefoxDriver();
                    }
                }
                return _driver;
            }
            set
            {
                Driver = _driver;
            }
        }

        public static void OpenPage(string pageTitle)
        {
            Driver.Navigate().GoToUrl(WebsiteUrl);
        }

        public static string GetPageTitle()
        {
            string pageTitle = null;
            pageTitle = Driver.Title;

            return pageTitle;
        }

        public static void Input(By by, string userName)
        {
            waitElement(by);
            Driver.FindElement(by).Clear();
            Driver.FindElement(by).SendKeys(userName);
        }

        public static void waitElement(By by)
        {
            var wd = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            wd.Until(d => d.FindElement(@by).Displayed);
        }

        public static void AssertElementExist(By by)
        {
            try
            {
                Driver.FindElement(by);
            }
            catch (NoSuchElementException e)
            {
                throw e;
            }

        }

        internal static void ClickElement(By by)
        {
            waitElement(by);
            Driver.FindElement(by).Click();
        }
    }
}
