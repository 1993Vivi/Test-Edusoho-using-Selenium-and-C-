using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ClassLibrary1.steps
{
    [Binding]
    public class _7_SearchOrdersSteps
    {
        [Given(@"I login in as admin")]
        public void GivenILoginInAsAdmin(Table table)
        {
            Page.HomePage.Goto();
            Page.HomePage.SelectLogin();
            var user = table.CreateInstance<Products>();
            Page.LoginPage.Loginto(user.Name, user.Password);
        }
        
        [Given(@"I go to ordermanage page")]
        public void GivenIGoToOrdermanagePage()
        {
            Page.HomePage.ClickAdmin();
            Page.AdminPage.Clickbtn();
        }
        
        [When(@"I click 课程订单 click 搜索")]
        public void WhenIClick课程订单Click搜索()
        {
            Page.OrdermanagePage.Plaintfind();
        }
        
        

        [When(@"I click 班级订单 click 搜索")]
        public void WhenIClick班级订单Click搜索()
        {
            Page.OrdermanagePage.Plaintfind1();
        }

        [Given(@"I go to ordermanage page click 课程订单")]
        public void GivenIGoToOrdermanagePageClick课程订单()
        {
            Page.HomePage.ClickAdmin();
            Page.AdminPage.Clickbtn();
        }

        [Given(@"I go to ordermanage page click 班级订单")]
        public void GivenIGoToOrdermanagePageClick班级订单()
        {
            Page.HomePage.ClickAdmin();
            Page.AdminPage.Clickbtn();
        }

        [Then(@"I see order number  more than zero")]
        public void ThenISeeOrderNumberMoreThanZero()
        {
            Assert.IsTrue(Page.OrdermanagePage.GetOrdernumbers()>0);
        }



        [When(@"select a (.*) and (.*) click 搜索")]
        public void WhenSelectAAndClick搜索(string Filter, string value)
        {
            Page.OrdermanagePage.Filters(Filter,value);
        }

        [When(@"I choose a (.*) and (.*)")]
        public void WhenIChooseAAnd(string filter, string Value)
        {
            Page.OrdermanagePage.Filters1(filter,Value);
        }


        [Then(@"I see (.*) course orders")]
        public void ThenISeeCourseOrders(int result)
        {
            Assert.IsTrue(Page.OrdermanagePage.GetOrdernumbers() == result);
        }

        [Then(@"I see (.*) class orders")]
        public void ThenISeeClassOrders(int result)
        {
            Assert.IsTrue(Page.OrdermanagePage.GetOrdernumbers() == result);
        }



    }
}
