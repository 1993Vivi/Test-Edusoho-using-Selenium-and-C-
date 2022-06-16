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
    public class OrdermanagePage
    {
       

        [FindsBy(How = How.LinkText, Using = "课程订单")]
        private IWebElement Courseorder;

        [FindsBy(How = How.LinkText, Using = "班级订单")]
        private IWebElement Classorder;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/button")]
        public IWebElement SearchBtn;


        [FindsBy(How = How.Id, Using = "order-table")]
        public IWebElement Ordertable;

        [FindsBy(How = How.Id, Using = "startDate")]
        private IWebElement Datepick;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[1]")]
        private IWebElement StatusChoice;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[2]")]
        private IWebElement Paymethod;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[3]/input")]
        private IWebElement Keyword;

        [FindsBy(How = How.CssSelector, Using = "[id^=order-table-]")]
        public IList<IWebElement> Orders;

       

        public void Plaintfind()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("课程订单")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/button")));
            Courseorder.Click();
            SearchBtn.Click();
        }

        public void Plaintfind1()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("班级订单")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/button")));
            Classorder.Click();
            SearchBtn.Click();
        }

        

        public int GetOrdernumbers()
        {
            // int RowCount = Browser.Driver2.FindElements(By.XPath("//*[@id='order-table']/tbody/tr")).Count;
            // Console.WriteLine(RowCount);

            int ordernumber = Orders.Count();
            return ordernumber;
        }
       

        public void Filters(string filter, string value)
        {
            if(filter=="date")
            {
                WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("课程订单")));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/button")));
                Courseorder.Click();

                Datepick.Click();
                Datepick.SendKeys(value);
                SearchBtn.Click();
            }
            if(filter== "status")
            {
                WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("课程订单"))).Click ();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/label"))).Click();

                StatusChoice.Click();

                SelectElement choices = new SelectElement(Browser.Driver2.FindElement(By.Name("status")));
                choices.SelectByText(value);
                SearchBtn.Click();
            }
            if(filter== "payment method")
            {

                WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("课程订单"))).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[2]")));

      
                Paymethod.Click();
                SelectElement methods = new SelectElement(Browser.Driver2.FindElement(By.Name("payment")));
                methods.SelectByText(value);
                SearchBtn.Click();
            }
            if(filter== "keyword")
            {
                WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("课程订单"))).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[3]/input")));


                Keyword.Click();
                Keyword.SendKeys(value);
                SearchBtn.Click();
            }
        }

        public void Filters1(string filter, string value)
        {
            if (filter == "date")
            {
                WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("班级订单"))).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/button")));
               
                Datepick.Click();
                Datepick.SendKeys(value);
                SearchBtn.Click();
            }
            if (filter == "status")
            {
                WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("班级订单"))).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/label"))).Click();

                StatusChoice.Click();

                SelectElement choices = new SelectElement(Browser.Driver2.FindElement(By.Name("status")));
                choices.SelectByText(value);
                SearchBtn.Click();
            }
            if (filter == "payment method")
            {

                WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("班级订单"))).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[2]")));


                Paymethod.Click();
                SelectElement methods = new SelectElement(Browser.Driver2.FindElement(By.Name("payment")));
                methods.SelectByText(value);
                SearchBtn.Click();
            }
            if (filter == "keyword")
            {
                WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("班级订单"))).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[3]/input")));


                Keyword.Click();
                Keyword.SendKeys(value);
                SearchBtn.Click();
            }
        }


    }
}
