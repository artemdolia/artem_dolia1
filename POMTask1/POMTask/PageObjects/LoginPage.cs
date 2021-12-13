using OpenQA.Selenium;
using Tests;

namespace PageObjects
{
    public class LoginPage : Program
    {
        private IWebElement ButtonCreateAccount => driver.FindElement(By.XPath("//*[@id='SubmitCreate']/span"));
        private IWebElement InputEmail => driver.FindElement(By.XPath("//input[@id='email']"));
        private IWebElement InputPassword => driver.FindElement(By.XPath("//input[@id='passwd']"));
        private IWebElement SignInButton => driver.FindElement(By.XPath("//button[@id='SubmitLogin']"));
        private IWebElement TitleAlreadyRegistered => driver.FindElement(By.XPath("//*[@id='login_form']/h3"));
        private IWebElement ErrorMessage => driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li"));
        private IWebElement ParagraphPlsEnterEmail => driver.FindElement(By.XPath("//*[@id='create-account_form']/div/p"));

        public string GetButtonCreate() => ButtonCreateAccount.Text;
        public void EnterEmail() => InputEmail.SendKeys("dolaartem688@gmail.com");
        public void EnterPassword() => InputPassword.SendKeys("pass123");
        public void ClickSignInButton() => SignInButton.Click();
        public string GetErrorMessage() => ErrorMessage.Text;
        public string GetTitleAlreadyRegistered() => TitleAlreadyRegistered.Text;
        public string GetTitlePleaseEnterEmail() => ParagraphPlsEnterEmail.Text;
    }
}