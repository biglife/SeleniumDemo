using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Configuration;

namespace TestChuke.Helper
{
    public  class BrowsersHelper
    {

        private static IWebDriver _driver;

        private string _browser;

        public   BrowsersHelper()
        {
           _browser= ConfigurationManager.AppSettings["Brower"]; 
        }

       
        public IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    if (_browser == "chrome")
                    {
                        _driver = new ChromeDriver();
                    }
                    else if (_browser == "ie")
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
    }
}
