using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Browser
    {
        //static IWebDriver webDriver = new FirefoxDriver();

        static IWebDriver webDriver;

        public static void InitDriver()
        {
            webDriver = new FirefoxDriver();
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver Driver2
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
