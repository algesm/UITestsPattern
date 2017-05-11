using OpenQA.Selenium;

namespace Tests.IDSRO.Core.Context
{
    /// <summary>
    /// Содержит текущий контекст и инструменты для работы
    /// </summary>
    public class WorkContext : IWorkContext
    {
        public WorkContext(IWebDriver browser)
        {
            Browser = browser;
            ContextParemeter  = new ContextParameter();
        }

        public ContextParameter ContextParemeter { get; }

        public IWebDriver Browser { get; }

    }
}