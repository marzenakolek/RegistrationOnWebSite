using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace RegistrationOnWebSite
{
    [Binding]
    public sealed class GitarowniaLogInStep
    {
        GitarowniaLogInPOM _loginSite = new GitarowniaLogInPOM(Environment.Driver);

        [Given(@"the user is on page ""(.*)""")]
        public void GivenTheUserIsOnPage(string p0)
        {
            Environment.Driver.Navigate().GoToUrl(p0);
        }
        [Then(@"he enters ""(.*)"" as login")]
        public void ThenHeEntersAsLogin(string login)
        {
            _loginSite.txtsignin_login_input.SendKeys(login);
        }

        [Then(@"he enters ""(.*)"" as password")]
        public void ThenHeEntersAsPassword(string password)
        {
            _loginSite.txtsignin_pass_input.SendKeys(password);
        }

        //[Given(@"clickle Log In button")]
        //public void GivenClickLogInButton()
        //{
        //    ((IJavaScriptExecutor)Environment.Driver).ExecuteScript("window.scrollTo(0," + _loginSite.btnsignin_button.Location.Y + ")");
        //    _loginSite.btnsignin_button.Click();
        //}

        //[Then(@"Twoje konto is created")]
        //public void ThenTwojeKontoIsCreated()
        //{
        //    _loginSite.linklogin.Click();
        //}
        [When(@"click sign In button")]
        public void WhenClickSignInButton()
        {
          
            ((IJavaScriptExecutor)Environment.Driver).ExecuteScript("window.scrollTo(0," + _loginSite.btnsignin_button.Location.Y + ")");
            _loginSite.btnsignin_button.Click();
        }
        [Then(@"User is on page: ""(.*)""")]
        public void ThenUserIsOnPage(string p0)
        {
         
            Thread.Sleep(5000);
            Assert.AreEqual(p0, Environment.Driver.Url);
        }


      //  [Then(@"click on Twoje konto")]
      //  public void ThenClickOnTwojeKonto()
      //  {
           /// _loginSite.linklogin.Click();
          
      //  }


    }
}
