using OpenQA.Selenium;
using SpecFlow1.Steps;

namespace SpecFlow1.Pages
{
    public class ContactPage:BaseStep
    {

        public IWebElement SubjectHeadingDropDown => webDriver.FindElement(By.Id("#id_contact"));
        public IWebElement CustomerServiceButton => webDriver.FindElement(By.XPath("//*[@id=\"id_contact\"]/option[2]"));
        public IWebElement EmailAddressField => webDriver.FindElement(By.XPath("//*[@id='email']"));
        public IWebElement OrderReferenceField => webDriver.FindElement(By.Id("id_order"));
        public IWebElement TextAreaMessage => webDriver.FindElement(By.Id("message"));
        public IWebElement SendButtonOnContactPage => webDriver.FindElement(By.XPath("//*[@id='submitMessage']"));
        public IWebElement SuccessMessageOnContactPage => webDriver.FindElement(By.XPath("//p[@class = 'alert alert-success']"));

        public void ClickSubjectHeadingDropDown() => SubjectHeadingDropDown.Click();
        public void ClickCustomerServiceButton() => CustomerServiceButton.Click();
        public void FeelEmailAddressField() => EmailAddressField.SendKeys("test@gmail.com");
        public void FeelOrderReferenceField() => OrderReferenceField.SendKeys("1231131");
        public void FeelTextAreaMessage() => TextAreaMessage.SendKeys("Test");
        public void ClickSendButtonOnContactPage() => SendButtonOnContactPage.Click();
        public string GetSuccessMessageOnContactPage() => SuccessMessageOnContactPage.Text;

    }
}
