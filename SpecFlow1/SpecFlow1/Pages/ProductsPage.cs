using OpenQA.Selenium;
using SpecFlow1.Steps;
using System.Collections.Generic;

namespace SpecFlowTask3.PageObjects
{
    public class ProductsPage : BaseStep
    {

        public IWebElement Summer => webDriver.FindElement(By.XPath("//h1/span[contains(text(),'Summer')]"));
        public IWebElement DropDown => webDriver.FindElement(By.Id("selectProductSort"));
        public IWebElement OptionByHighestFirst => webDriver.FindElement(By.XPath("//*[@id='selectProductSort']/option[3]"));
        public IWebElement AddToCartButton => webDriver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[2]/div[2]/a[1]/span"));
        public IWebElement Cart => webDriver.FindElement(By.XPath("//*[@id='header']/div[3]/div/div/div[3]/div/a"));
        public IWebElement ContinueShoppingButton => webDriver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span"));
        public IWebElement Blouse => webDriver.FindElement(By.XPath("//h1/span[contains(text(),'Blouse')]"));
        public IWebElement MoreButton => webDriver.FindElement(By.CssSelector("#center_column > ul > li > div > div.right-block > div.button-container > a.button.lnk_view.btn.btn-default > span"));
        public IWebElement OldPriceOfFirstDress => webDriver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[2]/div[1]"));
        public IWebElement PriceOfSecondDress => webDriver.FindElement(By.XPath("//*[@id='center_column']/ul/li[3]/div/div[2]/div[1]"));
        public IWebElement OldPriceOfThirdDress => webDriver.FindElement(By.XPath("//*[@id='center_column']/ul/li[3]/div/div[2]/div[1]"));
        public IWebElement PriceOfFourthDress => webDriver.FindElement(By.XPath("//*[@id='center_column']/ul/li[4]/div/div[2]/div[1]/span"));

        public bool GetDisplayedElement() => Summer.Displayed;
        public void ClickOnDropDown() => DropDown.Click();
        public void ClickOptionHighestFirst() => OptionByHighestFirst.Click();
        public bool ShowOptionHighestFirst() => OptionByHighestFirst.Displayed;
        public void ClickAddToCartButton() => AddToCartButton.Click();
        public void ClickTheCartButton() => Cart.Click();
        public void ClickContinueShoppingButton() => ContinueShoppingButton.Click();
        public void ClickOnTheButtonMore() => MoreButton.Click();
        public string GetPriceOfFirstDress() => OldPriceOfFirstDress.Text;
        public string GetPriceOfSecondDress() => PriceOfSecondDress.Text;
        public string GetPriceOfThirdDress() => OldPriceOfThirdDress.Text;
        public string GetPriceOfFourthDress() => PriceOfFourthDress.Text;

        public List<double> GetItemsOnProductsPage()
        {
            List<double> priceElements = new List<double>();
            var elements = webDriver.FindElements(By.XPath("//*[@id='center_column']/ul/li[*]/div"));

            foreach (var element in elements)

            {
                IWebElement oldPrice = null;
                IWebElement secondOldPrice = element.FindElement(By.XPath("//*[@id='center_column']/ul/li[3]/div/div[2]/div[1]/span[2]"));

                try
                {
                    oldPrice = element.FindElement(By.CssSelector("div > div.right-block > div.content_price > span.old-price.product-price"));
                }
                catch { }

                if (oldPrice == null)
                {
                    string price = element.FindElement(By.CssSelector("div > div.right-block > div.content_price > span")).Text.Replace("$", "");
                    double newPrice = double.Parse(price);
                    priceElements.Add(newPrice);
                }

                else if (oldPrice != null)
                {
                    var price = oldPrice.Text.Replace("$", "");
                    double convertPrice = double.Parse(price);
                    priceElements.Add(convertPrice);
                }
            }

            return priceElements;
        }
    }
}





