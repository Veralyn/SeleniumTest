using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;

namespace SeleniumTESTS.Pages
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }

    public class HomePage
    {
        private IWebDriver driver;

        private IWebDriver _driver { get; set; }
        public HomePage (IWebDriver driver)
        {
            IWebElement lnkLogin = driver.FindElement(By.LinkText("LOG IN"));
            var t = Task.Run(async () => 
            {
                lnkLogin.Click();
            });
            t.Wait(25000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            IWebElement txtEmail = driver.FindElement(By.Id("txtEmail"));
            IWebElement txtPassword = driver.FindElement(By.Id("txtPassword"));
            IWebElement btnLogin = driver.FindElement(By.Name("btnlogin"));
            txtEmail.SendKeys("admin@sidmach.com");
            txtPassword.SendKeys("sidmach@123");
            btnLogin.Submit();
            // _driver = new ChromeDriver();
        }


        //This is used click  the login button on the homepage//
        

        public void ClickLogin() 
        {
            IWebElement lnkLogin = _driver.FindElement(By.Name("LOG IN"));
            lnkLogin.Click();

            //wait
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        } 


    }
}
