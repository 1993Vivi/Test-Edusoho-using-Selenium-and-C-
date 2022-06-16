using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace ClassLibrary1.page
{
    public class OperationPage
    {



        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[1]/a[1]")]
        private IWebElement Manage;


        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[1]/div/a/span[1]")]
        private IWebElement segment;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/input")]
        private IWebElement input;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/input")]
        private IWebElement Keyword;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[3]/select")]
        private IWebElement Property;


        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[4]/select")]
        private IWebElement publishstatus;

        //[FindsBy(How = How.CssSelector, Using = "[id^=article-]")]
        //public IList<IWebElement> Articles;

       [FindsBy(How = How.XPath, Using = " //*[@id='article-table']/tbody/tr")]
       public IList<IWebElement> Articles;
      

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/button")]
        private IWebElement Searchbtn;
      

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/ul")]
        private IWebElement match;


        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/a[2]")]
        private IWebElement Changestatus;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/ul/li[1]/a")]
        private IWebElement Publish;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[7]/div/ul/li[1]/a")]
        private IWebElement Unpublish;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[1]/select")]
        private IWebElement Form;


        [FindsBy(How = How.XPath, Using = " /html/body/div[2]/div/div[2]/ul[1]/li[2]/a")]
        private IWebElement ManageSegment;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div/div/a")]
        private IWebElement Addarticle;


        [FindsBy(How = How.CssSelector, Using = "#category-save-btn")]
        private IWebElement Addbtn;

        [FindsBy(How = How.CssSelector, Using = "#category-name-field")]
        private IWebElement Addname;

        [FindsBy(How = How.CssSelector, Using = "#category-code-field")]
        private IWebElement AddID;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[2]/form/div[3]/div/div[1]/a/span[1]")]
        private IWebElement AddSegment;

        [FindsBy(How = How.CssSelector, Using = "#category-seoTitle-field")]
        private IWebElement AddTitle;

        [FindsBy(How = How.CssSelector, Using = "#category-seoKeyword-field")]
        private IWebElement AddKeyword;

        [FindsBy(How = How.CssSelector, Using = "#category-seoDesc-field")]
        private IWebElement AddDescription;
       

        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/input")]
        private IWebElement Input1;

      

       [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/ul[2]/li[2]/ul/li[1]/div/div[4]/a[1]")]
        private IWebElement Edit;
        

        [FindsBy(How = How.CssSelector, Using = "#category-name-field")]
        private IWebElement EditName;
        
        [FindsBy(How = How.CssSelector, Using = "#category-save-btn")]
        private IWebElement SaveEdit;

       // public string ActualString = Browser.Driver2.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[6]/span")).Text;




        public void AddanArticle(string name, string ID, string Segment, string Title, string keyword, string description)

        {
            ManageSegment.Click();
            Addarticle.Click();


            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/div[2]/form/div[3]/div/div[1]/a/span[1]")));



            Addname.Click();
            Addname.SendKeys(name);

            AddID.Click();
            AddID.SendKeys(ID);

            AddSegment.Click();
            Input1.Click();
            Input1.SendKeys(Segment);
            Input1.SendKeys(Keys.Enter);

            AddTitle.Click();
            AddTitle.SendKeys(Title);

            AddKeyword.Click();
            AddKeyword.SendKeys(keyword);

            AddDescription.Click();
            AddDescription.SendKeys(description);

            Addbtn.Click();

        }
                                                                              
        public int Getarticles()
        {
            int article = Articles.Count();
            Console.WriteLine(article);
            return article;

           
        }



        public void filters(string belong, string keyword, string property, string status)
        {

           
            if (belong != null && belong != "")  
            {
              
                segment.Click();
                input.Click();
                input.SendKeys(belong);
                input.SendKeys(Keys.Enter);
               

               // Searchbtn.Click();
            }
           // else
           // {
               if (keyword != null && keyword != "")
                {
                    Keyword.Click();
                    Keyword.SendKeys(keyword);
                  //  Searchbtn.Click();
               }
              //  else
               // {
                    if (property != null && property != "")
                    {
                        Property.Click();
                        SelectElement choices1 = new SelectElement(Browser.Driver2.FindElement(By.Name("property")));
                        choices1.SelectByText(property);
                       // Searchbtn.Click();
                    }

                    //else
                  //  {
                        if (status != null && status != "")
                        {
                            publishstatus.Click();
                            SelectElement choices2 = new SelectElement(Browser.Driver2.FindElement(By.Name("status")));
                            choices2.SelectByText(status);
                           
                        }
                       Searchbtn.Click();
            // }

            // }

            //}

        }

        public void Publishbtn()
        {
            Changestatus.Click();
            Publish.Click();
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 7));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[6]/span")));


        }
        public void Unpublishbtn()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
           
            Changestatus.Click();
            Unpublish.Click();
            WebDriverWait wait2 = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 7));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/div[2]/table/tbody/tr[1]/td[6]/span")));

        }

        
           
        public void ArticleEdit(string name)
        {
            ManageSegment.Click();
            Edit.Click();
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 7));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#category-seoTitle-field")));
            EditName.Click();
            EditName.Clear();
           

            EditName.SendKeys(name);
            SaveEdit.Click();
            WebDriverWait wait1 = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 7));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/ul[2]/li[2]/ul/li[1]/div/div[1]")));

           
        }
       
    }
}

