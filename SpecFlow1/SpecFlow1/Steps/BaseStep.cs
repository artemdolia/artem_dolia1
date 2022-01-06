using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;

namespace SpecFlow1.Steps
{
    public class BaseStep
    {
         public static IWebDriver webDriver;

        [Given(@"the site is opened in the '([^']*)'")]
        public void GivenTheSiteIsOpenedInTheChrome(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Edge":
                    webDriver = new EdgeDriver();
                    break;
                default:
                    break;
            }

            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");

        }
    }
}
