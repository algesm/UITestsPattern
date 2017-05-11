using System;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace Tests.IDSRO.Core.Context
{
    [Binding]
    public class WorkContextRegistration
    {
        private readonly IObjectContainer _objectContainer;

        public WorkContextRegistration(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }


        [BeforeScenario]
        public void InitializeRunTimeContex()
        {
            ContextParameter cp = new ContextParameter();
            _objectContainer.RegisterTypeAs<PageFactory, IPageFactory>();
            _objectContainer.RegisterInstanceAs<IWebDriver>(CreateWebDriver(cp.BrowserName));
            _objectContainer.RegisterTypeAs<WorkContext, IWorkContext>();
        }

        [AfterScenario()]
        public void Quit()
        {
            _objectContainer.Resolve<IWebDriver>().Quit();
        }

        private IWebDriver CreateWebDriver(string browserName)
        {
            IWebDriver webDriver;

            switch (browserName)
            {
                case "IE":
                    webDriver = new InternetExplorerDriver(new InternetExplorerOptions { IgnoreZoomLevel = true });
                    break;
                case "Edge":
                    webDriver = new EdgeDriver();
                    break;
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    throw new NotSupportedException($"{browserName} is not a supported browser");
            }
            return webDriver;
        }

    }
}