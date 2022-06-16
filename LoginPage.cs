using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "login_username")]
        private IWebElement UserName;

        [FindsBy(How = How.Id, Using = "login_password")]
        private IWebElement Password;

        [FindsBy(How = How.ClassName, Using = "js-btn-login")]
        private IWebElement LoginBtn;

        [FindsBy(How = How.Name, Using = "_remember_me")]
        private IWebElement RememberMe;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[1]")]
        private IWebElement WrongMessage;

        [FindsBy(How = How.LinkText, Using = "找回密码")]
        private IWebElement ResetPassword;

        public void Loginto(string name, string password)
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(OpenQA.Selenium.By.Id("login_username")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));

            UserName.Click();
            UserName.SendKeys(name);
            Password.Click();
            Password.SendKeys(password);
            LoginBtn.Click();
        }
        public void Login()
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(OpenQA.Selenium.By.Id("login_username")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));

            UserName.Click();
            UserName.SendKeys("test001");
            Password.Click();
            Password.SendKeys("Test1234");
            LoginBtn.Click();
        }




        public void Delete()
        {
            UserName.Clear();

        }

        public void Clickwm() => WrongMessage.Click();


        public void LoginRM(string name, string password)
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(OpenQA.Selenium.By.Id("login_username")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_username")));

            UserName.Click();
            UserName.SendKeys(name);
            Password.Click();
            Password.SendKeys(password);
            RememberMe.Click();
            RememberMe.Click();
            LoginBtn.Click();
        }

        public void GoResetPage()
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0,0,5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("找回密码")));
            ResetPassword.Click();

        }
    }
}
