using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using Tests.IDSRO.Core.Pages;

namespace Tests.IDSRO.Core.Setup
{
    [Binding]
    public sealed class Setup
    {
        private readonly IObjectContainer _objectContainer;
   
        public Setup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            IWebDriver webDriver = new FirefoxDriver();

            _objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }


    }
}