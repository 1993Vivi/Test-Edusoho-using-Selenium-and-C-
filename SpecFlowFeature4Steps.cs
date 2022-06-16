
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ClassLibrary1
{
    [Binding]
    public class SpecFlowFeature4Steps
    {
        [Given(@"I am in the registration page")]
        public void GivenIAmInTheRegistrationPage()
        {
            Page.HomePage.Goto();
            Page.HomePage.SelectRegister();
        }


        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            Page.RegistrationPage.Submit();
        }
        
   
        
        [Given(@"I input (.*)  (.*)  (.*) (.*)")]
        public void GivenIInput(string Email, string NickName, string Rpassword, string VerificationCode)
        {

            Page.RegistrationPage.Signup(Email, NickName, Rpassword, VerificationCode);

        }
        [Then(@"I see '(.*)' display")]
        public void ThenISeeDisplay(string ErrorType)

        {
           Assert.IsTrue(Browser.Driver2.PageSource.Contains(ErrorType));
            


        }
        
      
       




    }
}
