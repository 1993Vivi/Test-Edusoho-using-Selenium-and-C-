using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.steps
{
    [Binding]
    public class SpecFlowFeature5Steps
    {
        [Given(@"I am in login page")]
        public void GivenIAmInLoginPage()
        {
            Page.HomePage.Goto();
            Page.HomePage.SelectLogin();
        }
        
        [Given(@"I click password reset")]
        public void GivenIClickPasswordReset()
        {
            Page.LoginPage.GoResetPage();
        }

        
            [When(@"I input '(.*)' submit")]
            public void WhenIInputSubmit(string emailaddress)
            {
                Page.ResetpasswordPage.TypeEmail(emailaddress);
            }


            [Then(@"I see the '(.*)' display")]
        public void ThenISeeTheDisplay(string error)
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains(error));
        }

    }
}
