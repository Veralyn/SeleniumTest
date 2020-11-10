using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumTESTS.Pages
{
    public class LoginPage
    {

        public LoginPage()
        {
           
        }


        public void Login(IWebDriver driver, string txtEmail, string txtPassword)
        {


            driver.FindElement(By.Id("txtEmail")).SendKeys(txtEmail);
            driver.FindElement(By.Id("txtPassword")).SendKeys(txtPassword);
            driver.FindElement(By.Id("btnlogin")).Submit();

        }
    }

   

}
