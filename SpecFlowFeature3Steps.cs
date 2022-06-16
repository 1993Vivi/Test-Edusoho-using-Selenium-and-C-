using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.steps
{
    [Binding]
    public class SpecFlowFeature3Steps
    {
        [Given(@"I am in home page")]
        public void GivenIAmInHomePage()
        {
            Page.HomePage.Goto();
            Page.HomePage.SelectLogin();
            Page.LoginPage.Login();
        }
        
        [Given(@"I click my avatar,select icon setting")]
        public void GivenIClickMyAvatarSelectIconSetting()
        {
            Page.HomePage.ClickSetting();
        }
        
 
        [When(@"I upload my new avatar")]
        public void WhenIUploadMyNewAvatar()
        {
            Page.SettingPage.UploadAvatar();
        }
        
        [Then(@"I can see my new avatar")]
        public void ThenICanSeeMyNewAvatar()
        {
            Page.SettingPage.ClickNewAvatar();
        }
    }
}
