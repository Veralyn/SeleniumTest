using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTESTS.Pages;
using System;

namespace SeleniumTESTS
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://lmswebdev.azurewebsites.net/");
            HomePage homePage = new HomePage(driver);


        }
    }
}
