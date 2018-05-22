using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoAutomation.Pageobjects
{
    class MainPage
    {
        IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Log Out")]
        IWebElement logout;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public String getTitle()
        {
            String title = driver.Title;
            return title;
        }

        public void ClickonLogOut()
        {
            logout.Click();
        }
    }
}
