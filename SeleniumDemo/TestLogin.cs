using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumDemo
{
    public class TestLogin
    {
        public static void OpenBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://211.144.201.107:8080/#/");
        }
    }
}
