using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoAutomation.Pageobjects
{
    class LoginPage
    {
        IWebDriver driver;

        [FindsBy(How = How.Id, Using = "email")]
        IWebElement userName;

        [FindsBy(How = How.Id, Using = "pass")]
        IWebElement password;

        [FindsBy(How = How.Id, Using = "send2")]
        IWebElement login;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void SetUserName(String username)
        {
            userName.SendKeys(username);
        }
        public void SetPassword(String pass)
        {
            password.SendKeys(pass);
        }
        public void ClickOnLogin()
        {
            login.Click();
        }
    }
}
