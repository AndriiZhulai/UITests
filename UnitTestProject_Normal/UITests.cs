using NUnit.Framework;
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
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                driver.Navigate().GoToUrl("https://www.amazon.com/");
                driver.FindElement(By.Name("loginfmt")).SendKeys("anzh@simcorp.com");
                driver.FindElement(By.Id("idSIButton9")).Click();
            }

            [Test]
            public void MegadropdownA2()
            {
                //IWebElement element=driver.FindElement(By.LinkText("My Department"));
                //if (element.Displayed)
                //{
                //    GreenMessage("My Department tab is present on the page");
                //}
                //else
                //{
                //    RedMessage("ERROR, Element is not dispalyed");
                //}

                driver.FindElement(By.LinkText("My Department"));
                Console.WriteLine("My Department tab is present on the page");
                driver.FindElement(By.LinkText("Projects"));
                Console.WriteLine("Project tab is present on the page");
                driver.FindElement(By.LinkText("Clients"));
                Console.WriteLine("Clients tab is present on the page");
                driver.FindElement(By.LinkText("Divisions"));
                Console.WriteLine("Divisions tab is present on the page");
                driver.FindElement(By.LinkText("Employee"));
                Console.WriteLine("Employee tab is present on the page");
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

            [Test]
            public void Project()
            {
                driver.FindElement(By.LinkText("Projects"));
                Console.WriteLine("My Department tab is present on the page");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.FindElement(By.XPath("//span[text()='Projects']")).Click();
                //Find three main tabs
                driver.FindElement(By.XPath("//span[text()='Find a Project Site']"));
                driver.FindElement(By.XPath("//span[text()='Create SimLink Cloud project site']"));
                driver.FindElement(By.XPath("//span[text()='Search all project sites']"));
                //click on Title
                driver.FindElement(By.XPath("//span[text()='By Title']")).Click();
            }

            [Test]
            public void Clients()
            {
                driver.FindElement(By.LinkText("Clients"));
                Console.WriteLine("Clients tab is present on the page");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.FindElement(By.XPath("//span[text()='Clients']")).Click();
                //Find three main tabs
                driver.FindElement(By.XPath("//span[text()='Find a Client Site']"));
                driver.FindElement(By.XPath("//span[text()='Team Sites']"));
                driver.FindElement(By.XPath("//span[text()='Client Feedback']"));
                //Click on "Account Name"
                driver.FindElement(By.XPath("//span[text()='By Account Name']")).Click();
                driver.FindElement(By.XPath("//span[text()='Clients Overview (All Clients)']"));
                Console.WriteLine("__Clients website page__  is present");

                //check sorting process
                driver.FindElement(By.XPath("//*[@id=\"WPQ1_ListTitleViewSelectorMenu_Container_overflow\"]")).Click();
                //sort By Country
                driver.FindElement(By.LinkText("Sorted by Country")).Click();
                //save screenshot
                TakeScreenshot(driver, @"C:\Test\Sorted_by_country.png");



                //check dropdown list ... Як порахувати елементи в дропдауні якщо це едлемент який містить список option value і значення 
                //https://www.youtube.com/watch?v=niwku77dg_Y
                //IWebElement element=driver.FindElement(By.XPath("//*[@id=\"zz17_ViewSelectorMenu\"]"));
                //SelectElement selectElement = new SelectElement(element);
                //IList<IWebElement> elements = selectElement.Options;
                //Console.WriteLine(elements.Count);
                //foreach (var item in elements)
                //{
                //    Console.WriteLine(item.Text);
                //}
            }

            [Test]
            public void Divisions()
            {
                driver.FindElement(By.LinkText("Divisions"));
                Console.WriteLine("Divisions tab is present on the page");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.FindElement(By.XPath("//span[text()='Divisions']")).Click();
                //Find three main tabs
                driver.FindElement(By.XPath("//span[text()='Corporate Division']"));
                driver.FindElement(By.XPath("//span[text()='Group Marketing & Communications']"));
                driver.FindElement(By.XPath("//span[text()='ASP Division']"));
                driver.FindElement(By.XPath("//span[text()='Product Division']"));
                driver.FindElement(By.XPath("//span[text()='Market Division']"));
                driver.FindElement(By.XPath("//span[text()='Services Division']"));
                driver.FindElement(By.XPath("//span[text()='Organization']"));
                //Click 'Organisation Chart'
                driver.FindElement(By.LinkText("Organizational Chart")).Click();

            }



            [TearDown]
            public void TearDown()
            {
                //driver.Close();
            }



        }
    }
}


//        [Test]
//        public void FirstUiTest()
//        {
//            Console.WriteLine("test");
//            IWebDriver driver = new ChromeDriver();

//            driver.Manage().Window.Size = new System.Drawing.Size(1366, 768);
//            driver.Navigate().GoToUrl("http://old.qalight.com.ua/knowledge.html");

//            driver.FindElement(By.XPath("//*[@id=\"my_base\"]/li[1]/ul/li[1]/span")).Click();
//            System.Collections.Generic.List<IWebElement> linksToClick = driver.FindElement(By.CssSelector("//*[@id=\"my_base\"]/li[1]/ul/li[1]/ul")).FindElements(By.TagName("a")).ToList();
//            int linkCount = linksToClick.Count;

//            ////Click on button
//            //driver.FindElement(By.XPath("/html/body/div[2]/header/div/nav/div/div/div[2]/ul/li[8]/a")).Click();
//            //////Choose value in Dropdown
//            //driver.FindElement(By.Name("_7c8289bf6b8e80c1749ef54ab01b92b8")).Click();
//            //driver.FindElement(By.XPath("/html/body/div[2]/div[10]/form/div[1]/div/select/option[4]")).Click();

//            //////Enter secondname
//            //driver.FindElement(By.Name("_8fa5ea0c1de46e2bbcc7e19524976318")).SendKeys("Zhulai");

//            //////Enter firstname
//            //driver.FindElement(By.Name("_3e36f0d03b111a0d26353c24a901ef22")).SendKeys("Andrii");

//            //////Enter phone
//            //driver.FindElement(By.Id("z_text0")).SendKeys("0660604154");

//            //////Enter email
//            //driver.FindElement(By.Id("z_sender1")).SendKeys("test@ex.ua");

//            //////Enter skype
//            //driver.FindElement(By.Id("z_text2")).SendKeys("thisisskype");

//            //////Choose value in dropdown
//            //driver.FindElement(By.Name("_e926ba2b2813f56de8fc13877057e908")).Click();
//            //driver.FindElement(By.XPath("/html/body/div[2]/div[10]/form/div[7]/div/select/option[2]")).Click();

//            ////////Enter comment
//            //driver.FindElement(By.Name("_ad21040e29142e22bc370e7ecdb9e4b2")).SendKeys("Comment");

//            ////Click on button "Send"
//            ////driver.FindElement(By.XPath("/html/body/div[2]/div[10]/form/div[9]/div/button[1]")).Click();

//            ////Close driver
//            //driver.Close();
//            //driver.Quit();

//            //driver.Navigate().GoToUrl("https://qalight.com.ua/?gclid=CjwKCAiAuMTfBRAcEiwAV4SDkcxiwvcqUyQEmAOBY4fyViIiU_dkgl84drKeXN_nwq56bsjHMNl0DBoCMzYQAvD_BwE");


//            //var _driver = new ChromeDriver();
//            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
//            //driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/a")).Click();


//            //driver.SwitchTo().Window(driver.WindowHandles.Last());

//            ////Click on testing
//            //driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[1]/div[2]/ul/li[2]/a")).Click();

//            // //Hover                    

//            //IWebElement elementhover = driver.FindElement(By.XPath("//*[@id=\"two\"]/div/div/div[2]/div[24]"));

//            //Actions action = new Actions(driver);

//            //action.MoveToElement(elementhover).MoveToElement(driver.FindElement(By.LinkText("Подробнее"))).Click().Build().Perform();

//            //driver.FindElement(By.Name("first_name")).SendKeys("agileway");

//            ////driver.FindElement(By.LinkText("Подробнее")).Click();
//        }

//    }

//}
