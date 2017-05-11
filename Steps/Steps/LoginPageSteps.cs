using TechTalk.SpecFlow;
using Tests.IDSRO.Core.Base;
using Tests.IDSRO.Core.Context;
using Tests.IDSRO.Core.Pages;

namespace Tests.IDSRO.Core.Steps
{
    [Binding]
    public sealed class LoginPageSteps: StepBase<LoginPage>
    {
        public LoginPageSteps(IPageFactory factory)
            : base(factory)
        {
        }

        [When("Я заполняю имя пользователя '(.*)'")]
        public void ISetUserName(string userName)
        {
            Page.UserName.EnterText(userName);
        }

        [When("Я заполняю пароль '(.*)'")]
        public void ISetPassword(string password)
        {
            Page.Password.EnterText(password);
        }

        [When("Я включаю настройку сохранить пароль")]
        public void ICheckSavePassword()
        {
            Page.RememberMe.Select();
        }

        [When("Я выключаю настройку 'Сохранить пароль'")]
        public void IUnCheckSavePassword()
        {
            Page.RememberMe.Checked = false;
        }

        [When("Я нажимаю кнопку 'Войти'")]
        public void IClickLoginButton()
        {
            Page.SignIn();
        }

        [When("Я нажимаю кнопку 'Войти под доменным именем'")]
        public void IClickLoginAsDomainUserButton()
        {
            Page.SignInAsDomainUser();
        }

        [When("Я нажимаю ссылку 'Забыли пароль?'")]
        public void IClickForgotPassword()
        {
            Page.ForgotPassword.Click();
        }

        [When("Я нажимаю на banner")]
        public void IClickPageBanner()
        {
            Page.Banner.Click();
        }

        [When("Я навожу курсор на подсказку")]
        public void IHoverQuestionMark()
        {
            Page.Help.Click();
        }
    }
}
