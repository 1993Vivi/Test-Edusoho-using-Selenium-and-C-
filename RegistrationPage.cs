using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RegistrationPage
    {
        [FindsBy(How = How.Id, Using = "register_email")]
        private IWebElement EmailAddress;

        [FindsBy(How = How.Id, Using = "register_nickname")]
        private IWebElement NickName;

        [FindsBy(How = How.Id, Using = "register_password")]
        private IWebElement RPassword;

        [FindsBy(How = How.Id, Using = "captcha_code")]
        private IWebElement VerificationCode;


        [FindsBy(How = How.Id, Using = "register-btn")]
        private IWebElement Sbbutton;

        /*[FindsBy(How = How.Id, Using = "register_email-error")]
        private IWebElement Erroremail;

        [FindsBy(How = How.CssSelector, Using = "#register_nickname-error")]
        private IWebElement Errornickname;

        [FindsBy(How = How.Id, Using = "register_password-error")]
        private IWebElement Errorpassword;

        [FindsBy(How = How.Id, Using = "captcha_code-error")]
        private IWebElement Errorverification;*/


        public void Signup(string emailaddress, string nickname, string rpassword, string verificationcode)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_email")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("register_password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("captcha_code")));

            EmailAddress.Click();
            EmailAddress.SendKeys(emailaddress);
            NickName.Click();
            NickName.SendKeys(nickname);
            RPassword.Click();
            RPassword.SendKeys(rpassword);
            VerificationCode.Click();
            VerificationCode.SendKeys(verificationcode);

        }

        /*public void VerifyErrorMessage(string errormessage)
        {

            string actualText1 = Erroremail.Text;

            if
            (string.Equals(errormessage, actualText1))
            { Console.WriteLine("Test pass"); }
            else
            { Console.WriteLine("result not match"); }
            Browser.Close();
        }

           public void VerifyErrorMessage2(string errormessage2)
        {

            string actualText2 = Errornickname.Text;

            if
            (string.Equals(errormessage2, actualText2))
            { Console.WriteLine("Test pass"); }
            else
            { Console.WriteLine("result not match"); }
            Browser.Close();

        }

        public void VerifyErrorMessage3(string errormessage3)
        {

            string actualText3 = Errorpassword.Text;

            if
            (string.Equals(errormessage3, actualText3))
            { Console.WriteLine("Test pass"); }
            else
            { Console.WriteLine("result not match"); }
            Browser.Close();
        }

            public void VerifyErrorMessage4(string errormessage4)
         {

            string actualText4 = Errorverification.Text;

            if
            (string.Equals(errormessage4, actualText4))
            { Console.WriteLine("Test pass"); }
            else
            { Console.WriteLine("result not match"); }
            Browser.Close();*/
    


    //string.Equals(errormessage, actualText2);
    //string.Equals(errormessage, actualText3);
    // string.Equals(errormessage, actualText4);


    public void Submit() { Sbbutton.Click(); }

        

    }


    
}

