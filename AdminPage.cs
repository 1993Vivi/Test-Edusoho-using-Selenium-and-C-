using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.page
{
    public class AdminPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/ul[1]/li[4]/a")]
        private IWebElement Orderbtn;
        

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/ul[1]/li[3]/a")]
        private IWebElement Operationbtn;

        public void Clickbtn()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(OpenQA.Selenium.By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[4]/a")));
            Orderbtn.Click();
        }

        public void Clickoperation()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(OpenQA.Selenium.By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[3]/a")));
            Operationbtn.Click();
        }
    }
}
