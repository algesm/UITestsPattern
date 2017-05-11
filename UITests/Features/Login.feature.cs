﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.IDSRO.UITests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class АутентификацияПользователяFeature : Tests.IDSRO.UITests.TestFixture
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext;
        
#line 1 "Login.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this.testContext;
            }
            set
            {
                this.testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru-RU"), "Аутентификация пользователя", "\tПроверка страницы аутентификации", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Аутентификация пользователя")))
            {
                Tests.IDSRO.UITests.Features.АутентификацияПользователяFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            CheckTestState(TestContext);
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Успешная аутентификация пользователя")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Аутентификация пользователя")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Login")]
        public virtual void УспешнаяАутентификацияПользователя()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Успешная аутентификация пользователя", new string[] {
                        "Login"});
#line 5
  this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("Я перехожу на страницу \'Аутентификации\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Пусть ");
#line 7
 testRunner.When("Я заполняю имя пользователя \'sam\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 8
 testRunner.And("Я заполняю пароль \'sam\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 9
 testRunner.And("Я нажимаю кнопку \'Войти\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 10
 testRunner.Then("Я вижу страницу \'Главная\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void УспешнаяАутентификацияНесколькихПользователей(string login, string pwd, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Успешная аутентификация нескольких пользователей", exampleTags);
#line 12
 this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.Given("Я перехожу на страницу \'Аутентификации\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Пусть ");
#line 14
 testRunner.When(string.Format("Я заполняю имя пользователя \'{0}\'", login), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 15
 testRunner.And(string.Format("Я заполняю пароль \'{0}\'", pwd), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 16
 testRunner.And("Я нажимаю кнопку \'Войти\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 17
 testRunner.Then("Я вижу страницу \'Главная\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Успешная аутентификация нескольких пользователей: sam")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Аутентификация пользователя")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "sam")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:login", "sam")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:pwd", "sam")]
        public virtual void УспешнаяАутентификацияНесколькихПользователей_Sam()
        {
            this.УспешнаяАутентификацияНесколькихПользователей("sam", "sam", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Успешная аутентификация нескольких пользователей: operator1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Аутентификация пользователя")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "operator1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:login", "operator1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:pwd", "1")]
        public virtual void УспешнаяАутентификацияНесколькихПользователей_Operator1()
        {
            this.УспешнаяАутентификацияНесколькихПользователей("operator1", "1", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion