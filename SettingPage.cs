using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1.page
{
    public class SettingPage
    {
        [FindsBy(How = How.LinkText, Using = "头像设置")]
        private IWebElement AvatarSet;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/div/div[2]/form/div[3]/div[2]/a/div[2]/input")]
        private IWebElement Uploader1;

        [FindsBy(How = How.Id, Using = "upload-picture-btn")]
        private IWebElement Uploader;


        [FindsBy(How = How.CssSelector, Using = "#upload-avatar-btn")]
        private IWebElement Savebton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/a/img")]
        private IWebElement NewAvatar;

        [FindsBy(How = How.ClassName, Using = "glyphicon glyphicon-user")]
        private IWebElement BasicInfo;

        [FindsBy(How = How.Id, Using = "profile_truename")]
        private IWebElement TrueName;

        [FindsBy(How = How.Id, Using = "profile_idcard")]
        private IWebElement ProfileId;
        
        [FindsBy(How = How.Id, Using = "profile_mobile")]
        private IWebElement ProfileMobile;

       
        [FindsBy(How=How.Id,Using ="profile_title")]
        private IWebElement ProfileTitle;

        [FindsBy(How = How.Id, Using = "profile_site")]
        private IWebElement ProfileSite;

        [FindsBy(How = How.Id, Using = "weibo")]
        private IWebElement Weibo;

        [FindsBy(How = How.Id, Using = "profile_qq")]
        private IWebElement QQ;

        [FindsBy(How = How.Id, Using = "profile-save-btn")]
        private IWebElement ProfileBtn;
        

        public void ClickNewAvatar()
        {

            NewAvatar.Click();
        }


        public void UploadAvatar()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("头像设置")));
            

            AvatarSet.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("webuploader-pick")));

            Uploader.Click();

            Uploader1.SendKeys("C:\\Users\\Vivi\\Desktop\\pic\\avatar.jpg");

            Thread.Sleep(4000);
            
            Savebton.Click();

            Thread.Sleep(3000);



        }

        public void BasicInformation()
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("glyphicon glyphicon-user")));

            BasicInfo.Click();
        }

        public void InputProfileInfo(string truename, string id, string phonenumber, string profiletitle, string profilesite, string weibo, string profileqq)
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(Browser.Driver2,new TimeSpan(0,0,5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_truename")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_idcard")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_mobile")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_title")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_site")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("weibo")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_qq")));

            TrueName.Click();
            TrueName.Clear();
            TrueName.SendKeys(truename);

            ProfileId.Click();
            ProfileId.Clear();
            ProfileId.SendKeys(id);

            ProfileMobile.Click();
            ProfileMobile.Clear();
            ProfileMobile.SendKeys(phonenumber);

            ProfileTitle.Click();
            ProfileTitle.Clear();
            ProfileTitle.SendKeys(profiletitle);

            ProfileSite.Click();
            ProfileSite.Clear();
            ProfileSite.SendKeys(profilesite);

            Weibo.Click();
            Weibo.Clear();
            Weibo.SendKeys(weibo);

            QQ.Click();
            QQ.Clear();
            QQ.SendKeys(profileqq);

            ProfileBtn.Click();
           

        }
       

        public void save()
        {
            ProfileBtn.Click();
        }
}
}
