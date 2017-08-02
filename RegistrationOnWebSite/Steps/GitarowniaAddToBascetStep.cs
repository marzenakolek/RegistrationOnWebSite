using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using RegistrationOnWebSite.POM;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using RegistrationOnWebSite.Tools;
using OpenQA.Selenium.Remote;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using NUnit.Framework.Interfaces;

namespace RegistrationOnWebSite.Steps
{
    [Binding]
    public sealed class GitarowniaAddToBascetStep
    {
        GitarowniaAddToBascetPOM _addToBascetSite = new GitarowniaAddToBascetPOM (Environment.Driver);

        [Given(@"User is on page: ""(.*)""")]
        public void GivenUserIsOnPage(string p0)
        {
            Environment.Driver.Navigate().GoToUrl(p0);
        }

        [When(@"User enters ""(.*)""")]
        public void WhenUserEnters(string p1)
        {
            _addToBascetSite.txtmenu_search_text.SendKeys(p1);
        }

        [When(@"Click Search button")]
        public void WhenClickSearchButton()
        {
            _addToBascetSite.btnhiddenphone.Click();
        }

        [When(@"Click searched item")]
        public void WhenClickSearchedItem()
        {
            ((IJavaScriptExecutor)Environment.Driver).ExecuteScript("arguments[0].scrollIntoView();", _addToBascetSite.btnproduct);
            _addToBascetSite.btnproduct.Click();
        }

        [When(@"Clik Add to bascet button")]
        public void WhenClikAddToBascetButton()
        {
            Thread.Sleep(10000);
            ((IJavaScriptExecutor)Environment.Driver).ExecuteScript("arguments[0].scrollIntoView();", _addToBascetSite.btnbascet);
            _addToBascetSite.btnbascet.Click();
        }

        [When(@"Click on bacst icon and goes to bascet")]
        public void WhenClickOnBacstIconAndGoesToBascet()
        {
        
            WebDriverWait wait = new WebDriverWait(Environment.Driver, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>(d => _addToBascetSite.btnbascet1);


            ((IJavaScriptExecutor)Environment.Driver).ExecuteScript("arguments[0].scrollIntoView();", _addToBascetSite.btnbascet1);
            Thread.Sleep(10000);
            _addToBascetSite.btnbascet1.Click();
        }

        [Then(@"Check if ""(.*)"" is in bascet")]
        public void ThenCheckIfIsInBascet(string itemDisplayTextExpect)
        {
            Assert.AreEqual(true, _addToBascetSite.basketcaseItems.Any((item) => item.Text.Contains(itemDisplayTextExpect)));


            String javaScript = "var evObj = document.createEvent('MouseEvents');" +
                    "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
                    "arguments[0].dispatchEvent(evObj);";


            ((IJavaScriptExecutor)Environment.Driver).ExecuteScript(javaScript, _addToBascetSite.menubtnhover);

           
        }



        [AfterStep]
        public static void TestDDD()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var testscreen = ((ITakesScreenshot)Environment.Driver).GetScreenshot();
                var image = testscreen.AsByteArray;
                MemoryStream ms = new MemoryStream(image);
                Bitmap i = new Bitmap(Image.FromStream(ms));
                i.Save(LocalizationCustom.AssemblyDirectory + "\asd.jpg", ImageFormat.Jpeg);
            }
                
        }

    }
}
