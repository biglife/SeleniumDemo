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

        public void Open(string path)
        {
            SeleniumHelper.OpenPage(path);
        }

        public void InputUserName(string userName) 
        {
            SeleniumHelper.Input(By.Name("Account"),userName);
        }

        public void InputPassword(string password)
        {
            SeleniumHelper.Input(By.Name("PWD"), password);
        }

        internal void AssertLoginSuccessful()
        {
            SeleniumHelper.AssertElementExist(By.XPath("//article[@id='Home']"));
        }

        internal void Clicklogin()
        {
            SeleniumHelper.ClickElement(By.XPath("//article[@id='Home']/div/form/fieldset/section[4]/button"));
        }
    }
}
