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
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void InputUserName(string userName)
        {
            new SeleniumHelper(_driver).Input(By.Name("Account"), userName);
        }

        public void InputPassword(string password)
        {
            new SeleniumHelper(_driver).Input(By.Name("PWD"), password);
        }

        internal void AssertLoginSuccessful()
        {
            new SeleniumHelper(_driver).AssertElementExist(By.XPath("//article[@id='Home']"));
        }

        internal void Clicklogin()
        {
            new SeleniumHelper(_driver).ClickElement(By.XPath("//article[@id='Home']/div/form/fieldset/section[4]/button"));
        }

        internal void OpenPage(string pageUrl)
        {
            new SeleniumHelper(_driver).OpenPage(pageUrl);
        }

    }
}

