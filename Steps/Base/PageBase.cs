using OpenQA.Selenium;
using Tests.IDSRO.Core.Context;

namespace Tests.IDSRO.Core.Base
{
    public abstract class PageBase
    {
        protected PageBase(IWebDriver browser)
        {
            Browser = browser;
        }

        protected IWebDriver Browser { get; set; }
    }
}
