using BoDi;
using HtmlElements;
using OpenQA.Selenium;
using Tests.IDSRO.Core.Base;

namespace Tests.IDSRO.Core.Context
{
    public class PageFactory : IPageFactory
    {
        private readonly IWebDriver _driver;

        public PageFactory(IWebDriver driver)
        {
            _driver = driver;
        }

        public T GetInstance<T>() where T : PageBase
        {
            IPageObjectFactory objectFactory = new PageObjectFactory();
            T page = objectFactory.Create<T>(_driver);
            return page;
        }
    }
}
