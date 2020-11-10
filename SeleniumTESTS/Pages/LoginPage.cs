using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumTESTS.Pages
{
    public class LoginPage
    {
        private Iwebdriver webdriver;

        public LoginPage(Iwebdriver driver)
        {
            Driver = webdriver;
        }

        private Iwebdriver Driver { get;  }

        //IWebElement txtEmail = driver.FindElement(By.Id("txtEmail"));
        //IWebElement txtPassword = driver.FindElement(By.Id("txtPassword"));
       
        //public void Login(string txtEmail, string txtPassword)
        //{
         

        //    driver.FindElement(By.Id("txtEmail")).SendKeys(txtEmail);
        //    driver.FindElement(By.Id("txtPassword")).SendKeys(txtPassword);
        //    driver.FindElement(By.Id("btnlogin")).Submit();

        //}
    }

   

}
