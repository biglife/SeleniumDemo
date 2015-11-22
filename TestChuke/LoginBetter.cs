using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestChuke.Base;

namespace TestChuke
{
    /// <summary>
    /// Summary description for LoginBetter
    /// </summary>
    [TestClass]
    public class LoginBetter : CaseBase
    {
        [TestMethod]
        public void BetterLoginAdmin()
        {
            var loginPage = new PageObject.LoginPage(Driver);
           loginPage.OpenPage("http://211.144.201.107:8080/");
            loginPage.InputUserName("Sysadmin");
            loginPage.InputPassword("abc123");
            loginPage.Clicklogin();
            loginPage.AssertLoginSuccessful();
            
        }
    }
}
