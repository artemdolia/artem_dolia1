using OpenQA.Selenium;
using SpecFlow1.Steps;

namespace SpecFlowTask3.PageObjects
{
    public class BasePage : BaseStep
    {
        public IWebElement SearchArea => webDriver.FindElement(By.Id("search_query_top"));
        public IWebElement SearchButton => webDriver.FindElement(By.XPath("//*[@id='searchbox']/button"));
        public IWebElement ContactUsButton => webDriver.FindElement(By.Id("contact-link"));
        public IWebElement NewsLetterField => webDriver.FindElement(By.Id("newsletter-input"));
        public IWebElement SuccessMessageNewsLetter => webDriver.FindElement(By.XPath("//*[@id=\"columns\"]/p"));

        public void EnterText(string valueOfSearch) => SearchArea.SendKeys(valueOfSearch);
        public void ClickOnSearch() => SearchButton.Click();
        public void EnterBlouse() => SearchArea.SendKeys("Blouse");
        public void ClickContactUsButton() => ContactUsButton.Click();
        public void EnterEmailInNewsLetterField() => NewsLetterField.SendKeys("test@gmail.com");
        public void PressEnter() => NewsLetterField.SendKeys(Keys.Enter);
        public string GetSuccessMessageNewsLetter() => NewsLetterField.Text;

    }
}