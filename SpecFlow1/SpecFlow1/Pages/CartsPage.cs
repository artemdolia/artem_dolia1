using OpenQA.Selenium;
using SpecFlowTask3.TestRun;
using System;

namespace SpecFlow1.Pages
{
    public class CartsPage : SetUp
    {
        public IWebElement DeleteButton => webDriver.FindElement(By.XPath("//*[@id='5_25_0_0']/i"));
        public IWebElement BlousePrice => webDriver.FindElement(By.XPath("//*[@id='total_price']"));
        public IWebElement ParametresOfBlouse => webDriver.FindElement(By.XPath("//*[@id='product_2_12_0_0']/td[2]/small[2]/a"));
        public IWebElement ParametresOfDress => webDriver.FindElement(By.XPath("//*[@id='product_5_25_0_0']/td[2]/small[2]/a"));
        public IWebElement ColumnTotalPrice => webDriver.FindElement(By.Id("//*[@id='total_product']"));
        public IWebElement TotalProductsPrice => webDriver.FindElement(By.XPath("//*[@id=\"total_price\"]"));
        public IWebElement NameOfDress => webDriver.FindElement(By.XPath("//*[@id=\"product_5_19_0_0\"]/td[2]/p/a"));


        public void ClickDeleteButton() => DeleteButton.Click();
        public string GetBlousePrice() => BlousePrice.Text;
        public string GetBlouseParametres() => ParametresOfBlouse.Text;
        public string GetDressParemeters() => ParametresOfDress.Text;
        public string GetTota1lPrice() => ColumnTotalPrice.Text;
        public string GetTotalPrice() => TotalProductsPrice.Text;
        public string GetNameOfDress() => NameOfDress.Text;

        public void CheckThatDresIsNotRemains()
        {
            IWebElement summerDress = null;
            try
            {
                summerDress = webDriver.FindElement(By.XPath("//*[@id='product_5_25_0_0']/td[2]/small[2]/a"));
            }
            catch { }

            if(summerDress != null)
            {
                summerDress = webDriver.FindElement(By.XPath("//*[@id='product_5_25_0_0']/td[2]/small[2]/a"));
                string summerDressParametres = summerDress.Text;
            }
            else
            {
                Console.WriteLine("Dress is not returns on the page");
            }
        }

    }
}
