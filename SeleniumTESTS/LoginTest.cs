using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 
using SeleniumTESTS.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest
{
    class LoginTest
    {

        //This is used to open the browser//

        IWebDriver driver = new ChromeDriver();
        [SetUp]

        public void Setup()
        {
            //This navigates to desired URl//
            driver.Navigate().GoToUrl("https://lmswebdev.azurewebsites.net/");
        }

        [Test]

        public void Login()
        {
            HomePage homePage = new HomePage(driver);
            //homePage.ClickLogin();

            IWebElement lnkLogin = driver.FindElement(By.LinkText("LOG IN"));


            //This is used to perfom operations//
            lnkLogin.Click();

            //Find Email and Password//
            var txtEmail = driver.FindElement(By.Id("txtEmail"));
            var txtPassword = driver.FindElement(By.Id("txtPassword"));

            //This is used to enter email and password //

            txtEmail.SendKeys("admin@sidmach.com");
            txtPassword.SendKeys("sidmach@123");

            driver.FindElement(By.Id("txtEmail")).SendKeys("txtEmail");
            driver.FindElement(By.Id("txtPassword")).SendKeys("txtPassword");
            driver.FindElement(By.Id("btnlogin")).Submit();

            //Assertion i.e to verify if the code is successful or not//
            Assert.That(txtEmail.Displayed, Is.True);
            Assert.That(txtEmail.Displayed, Is.True);

        }

        [TearDown]
        public void TearDown() => driver.Quit();
    }
   




}