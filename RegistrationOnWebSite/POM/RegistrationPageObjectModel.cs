using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegistrationOnWebSite
{
    class RegistrationPageObjectModel
        
    {
        private IWebDriver _driver { get; set; }
        public RegistrationPageObjectModel (IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "client_firstname")]
        public IWebElement txtclient_firstname { get; set; }
        [FindsBy(How = How.Id, Using = "client_lastname")]
        public IWebElement txtclient_lastname { get; set; }
        [FindsBy(How = How.Id, Using = "client_street")]
        public IWebElement txtclient_street { get; set; }
        [FindsBy(How = How.Id, Using = "client_zipcode")]
        public IWebElement txtclient_zipcode { get; set; }
        [FindsBy(How = How.Id, Using = "client_city")]
        public IWebElement txtclient_city { get; set; }

        //Wybór państwa na drop down menu ????
        [FindsBy(How = How.Id, Using = "client_region")]
        public IWebElement btnclient_region { get; set; }
        //Radio button - adres dostawy, nie
        [FindsBy(How = How.Id, Using = "deliver_to_billingaddr1")]
        public IWebElement btndeliver_to_billingaddr1 { get; set; }
        //dane kontaktowe

        [FindsBy(How = How.Id, Using = "client_email")]
        public IWebElement txtclient_email { get; set; }
        [FindsBy(How = How.Id, Using = "client_phone")]
        public IWebElement nbclient_phone { get; set; }
        //dane logowania
        [FindsBy(How = How.Id, Using = "client_login")]
        public IWebElement txtclient_login { get; set; }
        [FindsBy(How = How.Id, Using = "client_password")]
        public IWebElement txtclient_password { get; set; }
        [FindsBy(How = How.Id, Using = "repeat_password")]
        public IWebElement txtrepeat_password { get; set; }
        //akceptacjA REGULAMINU
        [FindsBy(How = How.Id, Using = "terms_agree")]
        public IWebElement btnterms_agree { get; set; }
        //Zarejestruj konto
        [FindsBy(How = How.Id, Using = "submit_clientnew_form")]
        public IWebElement btnsubmit_clientnew_form { get; set; }
        }
}