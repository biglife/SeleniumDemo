using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChuke.PageObject
{
    public class LoginPage
    {
        private SeleniumHelper helper;
        public LoginPage(IWebDriver driver)
        {
            helper = new SeleniumHelper(driver);
        }

        public void InputUserName(string userName)
        {
            helper.Input(By.Name("Account"), userName);
        }

        public void InputPassword(string password)
        {
            helper.Input(By.Name("PWD"), password);
        }

        internal void AssertLoginSuccessful()
        {
            helper.AssertElementExist(By.XPath("//article[@id='Home']"));
        }

        internal void Clicklogin()
        {
            helper.ClickElement(By.XPath("//article[@id='Home']/div/form/fieldset/section[4]/button"));
        }

        internal void OpenPage(string pageUrl)
        {
            helper.OpenPage(pageUrl);
        }

    }
}

