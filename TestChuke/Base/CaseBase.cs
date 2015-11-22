using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TestChuke.Helper;

namespace TestChuke.Base
{
    public class CaseBase
    {
        public IWebDriver Driver;

        [TestInitialize]
        public void setup()
        {
            Driver =  new BrowsersHelper().Driver;
        }

        [TestCleanup]
        public void clenup()
        {
            Driver.Quit();
        }

    }
}
