using System;
using System.Threading;
using MagentoAutomation.Pageobjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MagentoAutomation
{
    public class MagentoTest
    {
        [Test]
        public void ValidCredential()
        {
            IWebDriver driver=null;
            try
            {
                driver = new ChromeDriver(@"D:\Mine\Company\Maveric\Driver");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Url = "https://magento.com/";

                //HomePage
                HomePage homePage = new HomePage(driver);
                homePage.ClickOnMyAccount();

                //LoginPage
                LoginPage loginPage = new LoginPage(driver);
                loginPage.SetUserName("balajidinakaran1@gmail.com");
                loginPage.SetPassword("Welcome123");
                loginPage.ClickOnLogin();

                //MainPage
                MainPage mainPage = new MainPage(driver);
                Thread.Sleep(5000);
                String title= mainPage.getTitle();
                Assert.AreEqual("My Account", title);
                mainPage.ClickonLogOut();
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message"+ ex);

                Screenshot s = ((ITakesScreenshot)driver).GetScreenshot();
                s.SaveAsFile("error.png");

                Assert.Fail();
            }
           

        }
        [Test]
        public void NegativeValidCredential()
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver(@"D:\Mine\Company\Maveric\Driver");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Url = "https://magento.com/";

                //HomePage
                HomePage homePage = new HomePage(driver);
                homePage.ClickOnMyAccount();

                //LoginPage
                LoginPage loginPage = new LoginPage(driver);
                loginPage.SetUserName("balajidinak@gmail.com");
                loginPage.SetPassword("Welcome123");
                loginPage.ClickOnLogin();

                //MainPage
                MainPage mainPage = new MainPage(driver);
                Thread.Sleep(5000);
                String title = mainPage.getTitle();
                Assert.AreEqual("My Account", title);
                mainPage.ClickonLogOut();
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message" + ex);

                Screenshot s = ((ITakesScreenshot)driver).GetScreenshot();
                s.SaveAsFile(@"D:\Mine\Company\UST-Global_Net\CSharp\MagentoAutomation\MagentoAutomation\error.png");

                Assert.Fail();
            }


        }


    }
}
