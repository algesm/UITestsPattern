using OpenQA.Selenium;

namespace Tests.IDSRO.Core.Context
{
    public interface IWorkContext
    {
        ContextParameter ContextParemeter { get; }

        IWebDriver Browser { get; }
    }
}