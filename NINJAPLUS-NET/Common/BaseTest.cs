using Coypu;
using Coypu.Drivers.Selenium;
using NINJAPLUS_NET.Page;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NINJAPLUS_NET.Common
{
    public class BaseTest
    {
        public BrowserSession browser;
      

        [SetUp]
        public void Setup()
        {
            var config = new SessionConfiguration
            {
                //AppHost = "http://automationpractice.com/index.php",
                //Port = 5000,
                SSL = false,
                Driver = typeof(SeleniumWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome,
                Timeout = TimeSpan.FromSeconds(10)
            };
            browser = new BrowserSession(config);


            browser.MaximiseWindow();
            browser.Visit("http://automationpractice.com/index.php");
        }

        [TearDown]
        public void Finish()
        {
            browser.Dispose();
        }
    }
}
