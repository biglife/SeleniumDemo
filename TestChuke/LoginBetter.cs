using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestChuke.Base;
using TestChuke.ObjectMother;

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
            loginPage.InputUserName(Users.Admin().UserName);
            loginPage.InputPassword(Users.Admin().Password);
            loginPage.Clicklogin();
            loginPage.AssertLoginSuccessful();
            
        }
    }
}
