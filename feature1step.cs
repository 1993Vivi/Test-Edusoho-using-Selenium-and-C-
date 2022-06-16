using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ClassLibrary1.Features
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I am in Home page")]
        public void GivenIAmInHomePage()
        {
            Page.HomePage.Goto();
        }

        [Given(@"I can select login")]
        public void GivenICanSelectLogin()
        {
            Page.HomePage.SelectLogin();
        }


        [When(@"I enter information and login and jump")]
        public void WhenIEnterInformationAndLoginAndJump(Table table)
        {
            var user = table.CreateInstance<Products>();
            Page.LoginPage.Loginto(user.Name, user.Password);
        }

        [When(@"I enter information and click remember me login")]
        public void WhenIEnterInformationAndClickRememberMeLogin(Table table)
        {
            var user = table.CreateInstance<Products>();
            Page.LoginPage.LoginRM(user.Name, user.Password);
        }

        [Given(@"I delete previous info")]
        public void GivenIDeletePreviousInfo()
        {
            Page.LoginPage.Delete();
        }


        [Then(@"I login successful and can see and click my avatar to logout")]
        public void ThenILoginSuccessfulAndCanSeeAndClickMyAvatarToLogout()
        {
            Page.HomePage.SelectLogout();
        }


        [Then(@"I cannot login, wrong message pop out")]
        public void ThenICannotLoginWrongMessagePopOut()
        {
            Page.LoginPage.Clickwm();
        }

        [Then(@"I can see and click my avatar")]
        public void ThenICanSeeMyAvatar()
        {
            Page.HomePage.ClickAvatar();
        }

        

    }
}


