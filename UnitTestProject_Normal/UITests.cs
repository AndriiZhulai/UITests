﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace UnitTestProject_Normal
{
    public class UITest
    {
        public class UnitTest1
        {
            IWebDriver driver;

            //IWebDriver driver = new ChromeDriver();
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
                //driver.FindElement(By.Id("ap_email")).SendKeys("andrii.zhulai@yahoo.com");
                ////Click on the button Continue
                //driver.FindElement(By.Id("continue")).Click();
                ////Enter password in the field password
                //driver.FindElement(By.Id("ap_password")).SendKeys("andrii.zhulai@yahoo.com");
                ////Click on the button "Sign in"
                //driver.FindElement(By.Id("signInSubmit")).Click();
                ////Find "Hello Andrii"
                //IWebElement element = driver.FindElement(By.CssSelector("#nav-link-accountList > span.nav-line-3"));
                /////new commit test                
            }

            //private void GreenMessage(string message)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine(message);
            //    Console.ForegroundColor = ConsoleColor.White;
            //}

            //private void RedMessage(string message)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(message);
            //    Console.ForegroundColor = ConsoleColor.White;
            //}


            //[Test]
            //public void Findsome()
            //{
            //    driver.FindElement(By.Id("twotabsearchtextbox"));
            //    //Console.WriteLine("Search field is present on the page");
            //    IWebElement incorerrectxpath = driver.FindElement(By.Id("nav-link-accountLis"));

            //    // try
            //    //{
            //    //    if (incorerrectxpath.Displayed)
            //    //    {
            //    //        GreenMessage("I see this element");
            //    //    }
            //    //}

            //    // catch (NoSuchElementException)
            //    //{
            //    //    RedMessage("I can not see this element");
            //    //}

            //    //if (incorerrectxpath.Displayed)
            //    //{
            //    //    GreenMessage("Hello, Andrii  ____ is present on the page");
            //    //}
            //    //else
            //    //{
            //    //    RedMessage("ERROR, Elemen_______is not dispalyed");
            //    //}

            //}


            //[Test]
            //public void Departments() //Check dropdown list
            //{
            //    driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("lebron james shoes");
            //    driver.FindElement(By.CssSelector("#nav-search > form > div.nav-right > div > input")).Click();
            //    //screenshot
            //    driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("rqwqwrwqrqwrqwrwqrqw");
            //    driver.FindElement(By.CssSelector("#nav-search > form > div.nav-right > div > input")).Click();
            //    // driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[2]/div/span[2]/div/span[1]")).Text;
            //}


            //[Test]
            //public void Dropdown()
            //{
            //    Actions action = new Actions(driver);
            //    IWebElement elem = driver.FindElement(By.LinkText("Departments"));
            //    action.MoveToElement(elem).Perform();

            //    //driver.FindElements(By.XPath("//*[@id=\"nav - flyout - shopAll\"]")).Count();

            //    //ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.XPath("//*[@id=\"nav-link-shopall\"]/span[2]"));
            //    //Console.WriteLine(elements.Count);
            //    //foreach(var item in elements)
            //    //{
            //    //    Console.WriteLine(item.Text);
            //    //}
            //    ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.TagName("span"));
            //    //tyt mozhna vukorustatu by tagname s vzyatu po  tegu napruclad h2
            //    Console.WriteLine(elements.Count);
            //    foreach (var item in elements)
            //    {
            //        Console.WriteLine(item.Text);
            //    }          
            //}
            /// <summary>
            /// /
            /// </summary>
            /// gsdfgsdfg

            [Test]
            public void Cart()
            {

                /* try
                 {
                     IWebElement body = driver.FindElement(By.TagName("body"));
                     Console.WriteLine("good");

                 }
                 catch (NoSuchElementException e)
                 {
                     Console.WriteLine("Unecspected element" + e.Message);
                 }*/
                Console.WriteLine("test");


            }

            //[Test]
            //public void Newtest()
            //{
            //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //    driver.FindElement(By.LinkText("Departments"));
            //    driver.FindElement(By.LinkText("Browsing History"));
            //    driver.FindElement(By.LinkText("Andrii's Amazon.com"));
            //    driver.FindElement(By.LinkText("Today's Deals"));
            //    driver.FindElement(By.LinkText("Gift Cards"));
            //    driver.FindElement(By.LinkText("Help"));
            //    driver.FindElement(By.LinkText("Registry"));
            //    Console.WriteLine("All links are present on the page");
            //}

           /* [Test]
            public void Department()
            {
                Actions action = new Actions(driver);
                IWebElement Departmets = driver.FindElement(By.LinkText("Departments"));
                action.MoveToElement(Departmets).Perform();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                driver.FindElement(By.LinkText("Prime Video"));
                Console.WriteLine("Prime Video is present");

                //Важлививй блок, коли дропдаун лыст складаэться  оптіонз (1б2б3 і так далі)
                //IWebElement element = driver.FindElement(By.LinkText("Departments"));
                //SelectElement selectElement = new SelectElement(element);
                //IList<IWebElement> elements = selectElement.Options;
                //Console.WriteLine(elements.Count);
                //foreach (var item in elements)
                //{
                //    Console.WriteLine(item.Text);
                //}
            }*/

           /* [Test]
            public void AndriiAmazon()
            {
                driver.FindElement(By.LinkText("Andrii's Amazon.com")).Click();
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.XPath("//*[@id=\"navFooter\"]/div[1]/div/div[5]/ul/li"));
                Console.WriteLine(elements.Count);

                if (elements.Count == 4)
                {
                    Console.WriteLine("Test passed");
                }
                else
                {
                    Console.WriteLine("Test failed");
                }            
            }*/

           /* [Test]
            public void GiftCards()
            {
                driver.FindElement(By.LinkText("Gift Cards")).Click();
                IReadOnlyCollection<IWebElement> element = driver.FindElements(By.ClassName("div[class='bxc-grid__column  bxc-grid__column--4-of-12   bxc-grid__column--light']"));
                Console.WriteLine(element.Count);

                //css selector for three elememts

            }*/



            [TearDown]
            public void TearDown()
            {
                //driver.Close();
            }



        }
    }
}



