using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject1.Configuration;
using UnitTestProject1.Interfaces;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       private readonly IConfig _config = new AppConfigReader();

        /*[TestMethod, TestCategory("smoke Test")]
        public void LunchBrowserAndCloseBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://kress2ml.github.io/prog-mine/html");
            driver.Close();
            //driver.Quit();
            driver.Dispose();
        }*/

        [TestMethod, TestCategory("smoke Test")]
        public void Navigate()
        {
            ConfigurationManager.AppSettings.Get("Browser");
            Console.WriteLine(BrowserType.Chrome);
            Console.WriteLine((int) BrowserType.Explorer);
        }

        [TestMethod,]
        public void SimpleMethod()
        {
            Console.WriteLine(_config.GetUserName());
            Console.WriteLine(_config.GetPassword());
            Console.WriteLine(_config.GetBrowser());
        }
    }

}
