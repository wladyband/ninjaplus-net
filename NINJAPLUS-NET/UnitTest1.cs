using Coypu;
using Coypu.Drivers.Selenium;
using NUnit.Framework;
using System.Threading;

namespace NINJAPLUS_NET
{
    public class Tests
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
                Browser = Coypu.Drivers.Browser.Chrome
                
            };

            browser = new BrowserSession(config);
        }

        [Test]
        public void Test1()
        {
            browser.Visit("http://automationpractice.com/index.php");
            Assert.Pass();
        }


        [TearDown]
        public void Finish()
        {
            
            browser.Dispose();
        }

    }
}