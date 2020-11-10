using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTESTS.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        private IWebDriver _driver { get; set; }
        public HomePage (IWebDriver driver)
        {
            IWebElement lnkLogin = driver.FindElement(By.LinkText("LOG IN"));
            lnkLogin.Click();
            // _driver = new ChromeDriver();
        }


        //This is used click  the login button on the homepage//
        

        public void ClickLogin() 
        {
            IWebElement lnkLogin = _driver.FindElement(By.Name("LOG IN"));
            lnkLogin.Click();

            ////wait
            //OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        } 


    }
}
