using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace WebDriverPage
{
    [TestClass]
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            Instance = new ChromeDriver(chromeDriverService);

            //Instance = new InternetExplorerDriver();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Instance.Close();
        }
    }
}
