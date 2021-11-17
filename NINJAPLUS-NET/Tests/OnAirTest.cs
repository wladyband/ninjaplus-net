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
        private AcessarTelaPrincipalPage _acessaPage; 

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
            _acessaPage = new AcessarTelaPrincipalPage(browser);
            _acessaPage.acessaTelaSistema("http://automationpractice.com/index.php");


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
