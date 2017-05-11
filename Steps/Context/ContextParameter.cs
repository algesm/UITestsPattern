using System.Configuration;

namespace Tests.IDSRO.Core.Context
{
    public class ContextParameter
    {
        public string BrowserName => ConfigurationManager.AppSettings["browser"];

        public string BaseUrl => ConfigurationManager.AppSettings["baseUrl"];

        public string ScreenshortsFolder => ConfigurationManager.AppSettings["screenshortsPath"];
    }
}