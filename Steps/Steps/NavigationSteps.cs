using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Tests.IDSRO.Core.Context;
using Tests.IDSRO.Core.Extension;

namespace Tests.IDSRO.Core.Steps
{
    [Binding]
    public class NavigationSteps
    {
        private readonly IWorkContext _context;

        public NavigationSteps(IWorkContext context)
        {
            _context = context;
        }

        [Given("Я перехожу на страницу '(.*)'")]
        public void IGoToPage(string pageName)
        {
            switch (pageName)
            {
                case "Аутентификации":
                    _context.Browser.NavigateTo(_context.ContextParemeter.BaseUrl,"/Account/Login");
                    break;
                case "Главная":
                default:
                    _context.Browser.NavigateTo(_context.ContextParemeter.BaseUrl,"/");
                    break;
            }
        }

        [Then("Я вижу страницу '(.*)'")]
        public void ISeePage(string pageName)
        {
            switch (pageName)
            {
                case "Аутентификации":
                    _context.Browser.CurrentPageIs("/Accounts/Login");
                    break;
                case "Главная":
                default:
                    _context.Browser.CurrentPageIs("/");
                    break;
            }
        }
    }
}
