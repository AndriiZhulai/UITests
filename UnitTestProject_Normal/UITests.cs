﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using System;
using System.Linq;
using System.Drawing.Imaging;

namespace UnitTestProject_Normal
{
    public class UITest
    {
        public class UnitTest1
        {
            IWebDriver driver;
            // private IWebElement element;;

            public void TakeScreenshot(IWebDriver driver, string saveLocation)
            {
                ITakesScreenshot ssdriver = driver as ITakesScreenshot;
                Screenshot screenshot = ssdriver.GetScreenshot();
                screenshot.SaveAsFile(saveLocation, ScreenshotImageFormat.Jpeg);
            }


            [SetUp]
            public void SetUp()
            {
                driver = new ChromeDriver();
                var options = new ChromeOptions();
                options.AddArgument("no-sandbox");
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                driver.Navigate().GoToUrl("https://www.amazon.com/");
                //Mouse Hover on Sign in
                Actions action = new Actions(driver);
                IWebElement loginBtn = driver.FindElement(By.CssSelector("#nav-link-accountList > span.nav-line-2 > span"));
                action.MoveToElement(loginBtn).Perform();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                
                //click on "Sinh in"
                driver.FindElement(By.CssSelector("#nav-flyout-ya-signin >a>span")).Click();
                //login with correct credentials
                //Enter value in email field
                driver.FindElement(By.Id("ap_email")).SendKeys("andrii.zhulai@yahoo.com");
                //Enter value in password field
                driver.FindElement(By.Id("ap_password")).SendKeys("andrii.zhulai@yahoo.com");
                //Click on the button "Sign in"
                driver.FindElement(By.Id("signInSubmit")).Click();
                //Find "Hello Andrii"
                IWebElement element = driver.FindElement(By.CssSelector("#nav-link-accountList > span.nav-line-3"));

                //if (element.Displayed)
                //{
                //    GreenMessage("Hello, Andrii  ____ is present on the page");
                //}
                //else
                //{
                //    RedMessage("ERROR, Elemen_______is not dispalyed");
                //}

                ///new commit test                
            }

            private void GreenMessage(string message)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            private void RedMessage(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            }


            [Test]
            public void Findsome()
            {
                driver.FindElement(By.Id("twotabsearchtextbox"));
                Console.WriteLine("Search field is present on the page");
            }


            [Test]
            public void Findsomeinformation()
            {
                driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("lebron james shoes");
                driver.FindElement(By.CssSelector("#nav-search > form > div.nav-right > div > input")).Click();



            }









            [TearDown]
            public void TearDown()
            {
                //driver.Close();
            }



        }
    }
}

