using OpenQA.Selenium;
using SpecFlowTask3.TestRun;

namespace SpecFlowTask3.PageObjects
{
    public class BasePage : SetUp
    {

        public IWebElement searchArea => webDriver.FindElement(By.Id("search_query_top"));
        public IWebElement searchButton => webDriver.FindElement(By.XPath("//*[@id='searchbox']/button"));

        public void EnterText(string valueOfSearch) => searchArea.SendKeys(valueOfSearch);
        public void ClickOnSearch() => searchButton.Click();
        public void EnterBlouse() => searchArea.SendKeys("Blouse");

    }
}