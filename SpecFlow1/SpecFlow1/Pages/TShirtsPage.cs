using OpenQA.Selenium;
using SpecFlow1.Steps;

namespace SpecFlow1.Pages
{
    public class TShirtsPage : BaseStep
    {

        public IWebElement QuantityField => webDriver.FindElement(By.Id("quantity_wanted"));
        public IWebElement DropDownSize => webDriver.FindElement(By.XPath("//div/select[@id='group_1']"));
        public IWebElement SizeOfItemL => webDriver.FindElement(By.XPath("//select[@id='group_1']/option[@title='L']"));
        public IWebElement ColorOfItem => webDriver.FindElement(By.Id("color_8"));
        public IWebElement AddToCartButton => webDriver.FindElement(By.XPath("//*[@id='add_to_cart']/button/span"));
        public IWebElement MessageSucess => webDriver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[1]/h2"));
        public IWebElement ButtonProceedToCheckout => webDriver.FindElement(By.XPath("//a[@class = 'btn btn-default button button-medium']/span"));
        public IWebElement ButtonContinueShopping => webDriver.FindElement(By.XPath("//span[@class='continue btn btn-default button exclusive-medium']"));
        public IWebElement ClearSearchInput => webDriver.FindElement(By.Id("search_query_top"));
        public IWebElement SizeOfItemM => webDriver.FindElement(By.XPath("//*[@id='group_1']/option[2]"));
        public IWebElement ColorOfItemOrange => webDriver.FindElement(By.XPath("//*[@id='color_13']"));
        public IWebElement FieldNameOfFriend => webDriver.FindElement(By.Id("friend_name"));
        public IWebElement FieldEmail => webDriver.FindElement(By.Id("friend_email"));
        public IWebElement ButtonSend => webDriver.FindElement(By.Id("sendEmail"));
        public IWebElement SuccessMessageHasBeenSent => webDriver.FindElement(By.XPath("//div/p[text() = 'Your e-mail has been sent successfully']"));
        public IWebElement ButtonSendToFriend => webDriver.FindElement(By.Id("send_friend_button"));

        public void DeleteDigitFromField() => QuantityField.Clear();
        public void FeelQuantityField(string quantity) => QuantityField.SendKeys(quantity);
        public void ClickDropDown() => DropDownSize.Click();
        public void SelectSizeL() => SizeOfItemL.Click();
        public void ClickWhite() => ColorOfItem.Click();
        public void ClickAddToCartButton() => AddToCartButton.Click();
        public string GetSucessMessage() => MessageSucess.Text;
        public void ClickProceedToCheckout() => ButtonProceedToCheckout.Click();
        public void ClickContinueShopping() => ButtonContinueShopping.Click();
        public void DeleteTextFromSearchInput() => ClearSearchInput.Clear();
        public void ClickSizeM() => SizeOfItemM.Click();
        public void ClickColorOrange() => ColorOfItemOrange.Click();
        public void EnterFriendName() => FieldNameOfFriend.SendKeys("Artem");
        public void EnterEmail() => FieldEmail.SendKeys("dolaartem68811@gmail.com");
        public string GetMessageHasBeenSent() => SuccessMessageHasBeenSent.Text;
        public void ClickSendToFriendButton() => ButtonSendToFriend.Click();
        public void ClickSendButton() => ButtonSend.Click();

    }
}
