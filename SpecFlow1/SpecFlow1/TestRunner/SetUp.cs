using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowTask3.TestRun
{
    [Binding]
    public class SetUp
    {
        protected static IWebDriver webDriver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            webDriver.Close();
        }
    }
}
