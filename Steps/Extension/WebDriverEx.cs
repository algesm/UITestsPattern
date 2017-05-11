using System;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using OpenQA.Selenium;

namespace Tests.IDSRO.Core.Extension
{
    /// <summary>
    /// Статический класс с расширением WebDriver
    /// </summary>
    public static class WebDriverEx
    {
        public static void NavigateTo(this IWebDriver driver, string baseUrl, string path)
        {
            driver.Navigate().GoToUrl(baseUrl.TrimEnd('/') + path);
        }

        public static bool CurrentPageIs(this IWebDriver driver , string path)
        {
            return driver.Url.Contains(path);
        }

        public static void CreateScreenShort(this IWebDriver driver, string folder, string name)
        {
            var browser = driver as ITakesScreenshot;
            browser?.GetScreenshot().SaveAsFile(GenarateScreenshortName(folder, name), ImageFormat.Png);
        }


        private static string GenarateScreenshortName(string folder, string name)
        {
            StringBuilder path =
                new StringBuilder(
                    folder.TrimEnd(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar))
            .Append(Path.DirectorySeparatorChar)
            .Append(name)
            .Append(ScreenshortNameSeparator)
            .Append(Guid.NewGuid())
            .Append(@".png");
            return path.ToString();
        }

        private const string ScreenshortNameSeparator = @"_";

        //private WebDriverWait _wait;
        //public WebDriverWait Wait => _wait ?? (_wait = new WebDriverWait(BrowserName, TimeSpan.FromSeconds(10)));

    }
}