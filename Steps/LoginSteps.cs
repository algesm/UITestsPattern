using System;
using TechTalk.SpecFlow;

namespace Tests.IDSRO.UITests....Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"Я на портале")]
        public void GivenЯНаПортале()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Я заполняю имя пользователя '(.*)'")]
        public void WhenЯЗаполняюИмяПользователя(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Я заполняю пароль '(.*)'")]
        public void WhenЯЗаполняюПароль(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Я нажимаю кнопку '(.*)'")]
        public void WhenЯНажимаюКнопку(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Я вижу главную страницу портала")]
        public void ThenЯВижуГлавнуюСтраницуПортала()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
