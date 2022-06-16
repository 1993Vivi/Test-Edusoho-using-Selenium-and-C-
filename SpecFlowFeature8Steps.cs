using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ClassLibrary1.steps
{
    [Binding]
    public class SpecFlowFeature8Steps
    {
        [Given(@"I login in admin account")]
        public void GivenILoginInAdminAccount(Table table)
        {
            Page.HomePage.Goto();
            Page.HomePage.SelectLogin();
            var user = table.CreateInstance<Products>();
            Page.LoginPage.Loginto(user.Name, user.Password);
        }
        
        [Given(@"I go to OperationPage")]
        public void GivenIGoToOperationPage()
        {
            Page.HomePage.ClickAdmin();
            Page.AdminPage.Clickoperation();
        }

        [When(@"I select (.*)  (.*)  (.*) (.*) filters")]
        public void WhenISelectFilters(string BELONG, string KEYWORD, string PROPERTY, string STATUS)
        {
            Page.OperationPage.filters(BELONG, KEYWORD, PROPERTY, STATUS);
        }




        [Then(@"I see (.*) displayed")]
        public void ThenISeeDisplayed(int result)
        {
            Assert.IsTrue(Page.OperationPage.Getarticles() == result);
            
        }

       


        [When(@"I select 编辑 发布")]
        public void WhenISelect编辑发布()
        {
            Page.OperationPage.Publishbtn();
        }


     

        [Then(@"I can see 已发布 display")]
        public void ThenICanSee已发布Display()
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("已发布"));
        }


        [When(@"I select 编辑 取消发布")]
        public void WhenISelect编辑取消发布()
        {
            Page.OperationPage.Unpublishbtn();
        }

        [Then(@"I can see 未发布 display")]
        public void ThenICanSee未发布Display()
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("未发布"));
        }

        [Given(@"I go to Operation page and manage segements")]
        public void GivenIGoToOperationPageAndManageSegements()
        {
            Page.HomePage.ClickAdmin();
            Page.AdminPage.Clickoperation();
           
        }
        [When(@"I add an new article")]
        public void WhenIAddAnNewArticle(Table table)
        {
            var news = table.CreateInstance<Article>();
            Page.OperationPage.AddanArticle(news.name, news.ID, news.Segment, news.Title, news.keyword, news.description);
        }


       
        [Then(@"I Can see new article  displayed")]
        public void ThenICanSeeNewArticleDisplayed()
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("0098AB"));
        }

        [When(@"I change a name of an article to name below")]
        public void WhenIChangeANameOfAnArticleToNameBelow(Table table)
        {

            var NewName = table.CreateInstance<EditName>();
            Page.OperationPage.ArticleEdit(NewName.name);
        }


        [Then(@"I Can see updated article  displayed")]
        public void ThenICanSeeUpdatedArticleDisplayed()
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("test89773"));
        }



    }
}
