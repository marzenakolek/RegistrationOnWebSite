using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace RegistrationOnWebSite
{
    [Binding]
    public static class Environment
    {

        static Environment()
        {
            Driver = new ChromeDriver();
           
        }
        public static IWebDriver Driver { get; set; }


        [AfterTestRun]
        public static void TearDown()
        {
            Driver.Close();
        }


    }
}     
            
        
    

