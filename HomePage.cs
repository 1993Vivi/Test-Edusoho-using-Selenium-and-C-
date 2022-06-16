using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HomePage 
    {
        static string Url = "http://lyratesting2.co.nz/";

        [FindsBy(How = How.LinkText, Using = "登录")]
        private IWebElement Login;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/a/img")]
        private IWebElement Logout;

        [FindsBy(How = How.LinkText, Using = "注册")]
        private IWebElement Register;
        //login method 
        public void SelectLogin()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("登录")));

            Login.Click();

        }

        public void SelectRegister()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("注册")));

            Register.Click();
        }

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public void SelectLogout()
        {

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));

            Logout.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[9]"))).Click();

        }

        public void ClickAvatar()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));

            Logout.Click();

        }

        public void ClickSetting()
        {

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));

            Logout.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[3]/a"))).Click();

        }

        public void ClickAdmin()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));

            Logout.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".user-avatar-li > ul:nth-child(2) > li:nth-child(6) > a:nth-child(1)"))).Click();



        }
    } 
}
