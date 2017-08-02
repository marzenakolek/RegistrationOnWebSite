using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RegistrationOnWebSite.Utilities;

namespace RegistrationOnWebSite
{
    [Binding]
    public sealed class RegistrationOnWebSiteStep
    {
        RegistrationPageObjectModel _rpSite = new RegistrationPageObjectModel(Environment.Driver);
        NameGenerator _namegenerator = new NameGenerator(Environment.Driver);

        public string PreviousName { get; private set; }
        public string PreviousSecondname { get; private set; }

        [Given(@"the user is on ""(.*)""")]
        public void GivenTheUserIsOn(string p0)
        {
            Environment.Driver.Navigate().GoToUrl("https://gitarownia.iai-shop.com/client-new.php?register");
        }

        [When(@"he enters ""(.*)"" as name")]
        public void WhenHeEntersAsName(string name)
        {
            _rpSite.txtclient_firstname.SendKeys(_namegenerator.SendKey(PreviousName));
        }

        [When(@"he enters ""(.*)"" as second name")]
        public void WhenHeEntersAsSecondName(string secondName)
        {
            _rpSite.txtclient_lastname.SendKeys(_namegenerator.SendKey(PreviousSecondname));
        }

        [When(@"he enters ""(.*)"" as street number")]
        public void WhenHeEntersAsStreetNumber(string street)
        {
            _rpSite.txtclient_street.SendKeys(street);
        }

        [When(@"he enters ""(.*)"" as zip-code")]
        public void WhenHeEntersAsZip_Code(string zipcode)
        {
            _rpSite.txtclient_zipcode.SendKeys(zipcode);
        }

        [When(@"he enters ""(.*)"" as city")]
        public void WhenHeEntersAsCity(string city)
        {
            _rpSite.txtclient_city.SendKeys(city);
        }
        
        [When(@"he Sellect ""(.*)"" as country")]
        public void WhenHeSellectAsCountry(string p0)
        {
            new SelectElement(_rpSite.btnclient_region).SelectByText("Litwa");
        }

        [When(@"he accept ""(.*)"" in delivery address")]
        public void WhenHeAcceptInDeliveryAddress(string a)
        {
            _rpSite.btndeliver_to_billingaddr1.Click();
        }

        [When(@"he enters ""(.*)"" as email")]
        public void WhenHeEntersAsEmail(string email)
        {
            _rpSite.txtclient_email.SendKeys(email);
        }

        [When(@"he enters ""(.*)"" as telephone number")]
        public void WhenHeEntersAsTelephoneNumber(string billingRate )
        {
            _rpSite.nbclient_phone.SendKeys(billingRate);
        }

        [When(@"he enters ""(.*)"" as login")]
        public void WhenHeEntersAsLogin(string login)
        {
            _rpSite.txtclient_login.SendKeys(login);
        }

        [When(@"he enters ""(.*)"" as password")]
        public void WhenHeEntersAsPassword(string password)
        {
            _rpSite.txtclient_password.SendKeys(password);
        }

        [When(@"he enters ""(.*)"" as repeat password")]
        public void WhenHeEntersAsRepeatPassword(string repeatpassword)
        {
            _rpSite.txtrepeat_password.SendKeys(repeatpassword);
        }

        [When(@"he accept ""(.*)""")]
        public void WhenHeAccept(string p0)
        {
            ((IJavaScriptExecutor)Environment.Driver).ExecuteScript("window.scrollTo(0," + _rpSite.btnterms_agree.Location.Y + ")");
            _rpSite.btnterms_agree.Click();
        }

        [When(@"he Submits request on account registration")]
        public void WhenHeSubmitsRequestOnAccountRegistration()
        {
            _rpSite.btnsubmit_clientnew_form.Click();
        }

        [Then(@"he can go to ""(.*)""")]
        public void ThenHeCanGoTo(string p0)
        {
            Assert.AreEqual(p0, Environment.Driver.Url);

        }


    }
}
