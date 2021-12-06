using OpenQA.Selenium;
using Tests;


namespace PageObjects
{
    public class LoginPage : Program
    {


        private IWebElement btnCreateAccount => driver.FindElement(By.XPath("//*[@id='SubmitCreate']/span"));
        private IWebElement txtEmailCreate => driver.FindElement(By.XPath("//input[@id='email_create']"));
        private IWebElement txtEmail => driver.FindElement(By.XPath("//input[@id='email']"));
        private IWebElement password => driver.FindElement(By.XPath("//input[@id='passwd']"));
        private IWebElement signInButton => driver.FindElement(By.XPath("//button[@id='SubmitLogin']"));
        private IWebElement titleAlreadyRegistered => driver.FindElement(By.XPath("//*[@id='login_form']/h3"));
        private IWebElement errorMsg => driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li"));
        private IWebElement paragraphPlsEnterEmail => driver.FindElement(By.XPath("//*[@id='create-account_form']/div/p"));

        public string GetTextBtnCreate() => btnCreateAccount.Text;
        public void SendTextToCreateEmail() => txtEmailCreate.SendKeys("awdadada11221@gmail.com");
        public void SendTextToEmail(string Artem) => txtEmail.SendKeys("cat");
        public void SendTextToPassword(string summer123) => password.SendKeys(summer123);
        public void ClickSignInBtn() => signInButton.Click();
        public string GetErrorMessage() => errorMsg.Text;
        public string GetTextAlreadyRegistered() => titleAlreadyRegistered.Text;
        public string GetTextPlsEnterEmail() => paragraphPlsEnterEmail.Text;

    }
}