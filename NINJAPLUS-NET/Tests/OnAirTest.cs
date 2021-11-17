using Coypu;
using Coypu.Drivers.Selenium;
using NINJAPLUS_NET.Page;
using NUnit.Framework;
using System;
using System.Threading;

namespace NINJAPLUS_NET.Tests
{
    public class OnAirTest
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
            var page = new AcessarTelaPrincipalPage(browser);
            page.acessaTelaSistema("http://automationpractice.com/index.php");

            browser.MaximiseWindow();
        }

        [Test]
        public void Test1()
        {
          

        }


        [TearDown]
        public void Finish()
        {
            browser.Dispose();
        }
    }
}
