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
    public class ResetpasswordPage
    {

        [FindsBy(How = How.Id, Using = "form_email")]
        private IWebElement EmailInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div/div/form[1]/div[2]/div/button")]
        private IWebElement Submitbtn;

        public void TypeEmail(string email )
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(OpenQA.Selenium.By.Id("form_email")));
            wait.Until(ExpectedConditions.ElementIsVisible(OpenQA.Selenium.By.XPath("/html/body/div[1]/div[1]/div/div/div/form[1]/div[2]/div/button")));

            EmailInput.Click();
            EmailInput.SendKeys(email);
            Submitbtn.Click();

        }
 
    }
}
