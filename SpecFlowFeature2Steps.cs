using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ClassLibrary1
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        [Given(@"I go to Home page")]
        public void GivenIGoToHomePage()
        {
            Page.HomePage.Goto();
        }

        [Given(@"I select login")]
        public void GivenISelectLogin()
        {
            Page.HomePage.SelectLogin();
        }

        [When(@"I enter my information and login")]
        public void WhenIEnterMyInformationAndLogin(Table table)
        {
            var user = table.CreateInstance<Products>();
            Page.LoginPage.Loginto(user.Name, user.Password);
        }

        [Then(@"I click my avatar to logout, login webpage is seen")]
        public void ThenIClickMyAvatarToLogoutLoginWebpageIsSeen()
        {
            Page.HomePage.SelectLogout();

        }
    }
}
