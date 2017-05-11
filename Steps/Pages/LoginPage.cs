using HtmlElements.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;
using Tests.IDSRO.Core.Base;
using Tests.IDSRO.Core.Context;

namespace Tests.IDSRO.Core.Pages
{
    public class LoginPage : PageBase
    {
        public LoginPage(IWebDriver browser) : base(browser)
        { }
        
        [FindsBy(How = How.XPath, Using = "//input[@name='UserName']")]
        public HtmlInput UserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='Password']")]
        public HtmlInput Password { get; set; }

        [FindsBy(How = How.Id, Using = "save-password-check")]
        public HtmlCheckBox RememberMe { get; set; }

        [FindsBy(How = How.ClassName, Using = "forgot-password")]
        public HtmlLink ForgotPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[@class='login-logo']/a")]
        public HtmlLink Banner { get; set; }

        [FindsBy(How = How.ClassName, Using = "header-help")]
        public HtmlLabel Help { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='login-form']/input[@class='main']")]
        protected HtmlLabel LogIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='domen-name-login']/form/input[@class='main']")]
        protected HtmlLabel LogInAsDomainUser { get; set; }

        public void SignIn()
        {
            if (Browser is EdgeDriver)
                LogIn.ExecuteScript("arguments[0].click()", LogIn);
            else
                LogIn.Click();
        }

        public void SignInAsDomainUser()
        {
            if (Browser is EdgeDriver)
                LogInAsDomainUser.ExecuteScript("arguments[0].click()", LogIn);
            else
                LogInAsDomainUser.Click();
        }
    }
}
