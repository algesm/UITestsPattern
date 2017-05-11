using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Tests.IDSRO.Core;
using Tests.IDSRO.Core.Context;
using Tests.IDSRO.Core.Extension;

namespace Tests.IDSRO.UITests
{
    [TestClass]
    public class TestFixture
    {
        public void CheckTestState(TestContext testContext)
        {
            if (testContext.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                var context = ScenarioContext.Current.ScenarioContainer.Resolve<IWorkContext>();
                 context.Browser.CreateScreenShort(context.ContextParemeter.ScreenshortsFolder, testContext.TestName);
            }
        }

    }

}
