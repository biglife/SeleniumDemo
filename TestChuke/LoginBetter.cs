using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestChuke
{
    /// <summary>
    /// Summary description for LoginBetter
    /// </summary>
    [TestClass]
    public class LoginBetter
    {
        

        [TestMethod]
        public void BetterLoginAdmin()
        {
            var loginPage = new PageObject.LoginPage();
            loginPage.Open("http://211.144.201.107:8080/");
            loginPage.InputUserName("Sysadmin");
            loginPage.InputPassword("abc123");
            loginPage.Clicklogin();
            loginPage.AssertLoginSuccessful();
            //
            // TODO: Add test logic here
            //
        }
    }
}
