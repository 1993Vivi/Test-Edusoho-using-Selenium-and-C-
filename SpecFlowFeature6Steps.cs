using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ClassLibrary1.steps
{
    [Binding]
    public class SpecFlowFeature6Steps
    {
        [Given(@"I login with user and goto setting page")]
        public void GivenILoginWithUserAndGotoSettingPage()
        {
            Page.HomePage.Goto();
            Page.HomePage.SelectLogin();
            Page.LoginPage.Login();
            Page.HomePage.ClickSetting();
        }


   

        [Given(@"I update my info")]
        public void GivenIUpdateMyInfo(Table table)
        {
            var add = table.CreateInstance<Addinfo>();
            Page.SettingPage.InputProfileInfo(add.TrueName,add.ID,add.PhoneNumber,add.ProfileTitle,add.ProfileSite,add.Weibo,add.ProfileQQ );
        }

        [Given(@"I input my info")]
        public void GivenIInputMyInfo(Table table)
        {
            var add = table.CreateInstance<Addinfo>();
            Page.SettingPage.InputProfileInfo(add.TrueName, add.ID, add.PhoneNumber, add.ProfileTitle, add.ProfileSite, add.Weibo, add.ProfileQQ);
        }




        [Given(@"I input (.*), (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void GivenIInput(string TrueName, string ID, string PhoneNumber, string ProfileTitle, string ProfileSite, string Weibo, string ProfileQQ)
        {
            Page.SettingPage.InputProfileInfo(TrueName,ID,  PhoneNumber, ProfileTitle,ProfileSite,Weibo, ProfileQQ);
        }
        
        [When(@"I press 保存")]
        public void WhenIPress保存()
        {
            Page.SettingPage.save();
        }

       
        [Then(@"I can see “基础信息保存成功。”  display on screen")]
        public void ThenICanSee基础信息保存成功DisplayOnScreen()
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("基础信息保存成功。"));
        }



        [Then(@"I can see errors")]
        public void ThenICanSeeErrors(Table table)
        {
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("最多只能输入 18 个字符"));
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("请正确输入您的身份证号码"));
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("请输入正确的手机号"));
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("最多只能输入 24 个字符"));
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("地址不正确，须以http://或者https://开头。"));
            Assert.IsTrue(Browser.Driver2.PageSource.Contains("请输入正确的QQ号"));


        }



    }
}
