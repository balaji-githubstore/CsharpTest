using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoAutomation.Pageobjects
{
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "MY ACCOUNT")]
        IWebElement myAccount;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        public void ClickOnMyAccount()
        {
            try
            {
                myAccount.Click();
            }
            catch(Exception e)
            {
                throw;
            }
            
        }
    }
}
