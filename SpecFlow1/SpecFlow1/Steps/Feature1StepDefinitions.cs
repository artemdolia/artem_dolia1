using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlow1.Constant;
using SpecFlow1.Pages;
using SpecFlow1.Steps;
using SpecFlowTask3.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowTask3.Steps
{
    [Binding]
    public class Feature1StepDefinitions
    {
        private IWebDriver webDriver;

        static void Main()
        {
        }
        

        [Given(@"the user enters '([^']*)' in search-field on the base page")]
        public void GivenTheUserEntersSummerInInput_Field(string valueOfSearch)
        {
            BasePage basePage = new BasePage();
            basePage.EnterText(valueOfSearch);
        }

        [When(@"the user clicks on the search button")]
        public void WhenTheUserClicksOnSearchButton()
        {
            BasePage basePage = new BasePage();
            basePage.ClickOnSearch();
        }

        [Then(@"Summer is displayed in line Search above list of products on the base page")]
        public void ThenSummerIsDisplayedInLineSearchAboveListOfProducts()
        {
            Thread.Sleep(1000);

            ProductsPage productsPage = new ProductsPage();
            productsPage.GetDisplayedElement();
            bool summerDisplayed = productsPage.GetDisplayedElement();

            Assert.IsTrue(summerDisplayed,"Summer is not displayed");
        }

        [Given(@"the user clicks on the search button")]
        public void GivenTheUserClicksOnSearchButton()
        {
            BasePage basePage = new BasePage();
            basePage.ClickOnSearch();
        }

        [When(@"the user choices option Price: Highest first on the products page")]
        public void WhenTheUserChoicesOptionPriceHighestFirst()
        {
            ProductsPage productsPage = new ProductsPage();
            productsPage.ClickOptionHighestFirst();
        }

        [Then(@"sorting is performed from high price to low on the products page")]
        public void ThenSortingIsPerformedFromHighPriceToLow()
        {
            ProductsPage productsPage = new ProductsPage();
            var actualOrder = productsPage.GetItemsOnProductsPage();
            var expectedOrder = actualOrder.OrderByDescending(s => s);
            Assert.AreEqual(expectedOrder, actualOrder, "Sorting on page is performed wrong");
        }

        [Given(@"the user choices option Price: Highest first on products page")]
        public void GivenTheUserChoicesOptionPriceHighestFirst()
        {
            ProductsPage productsPage = new ProductsPage();
            productsPage.ClickOptionHighestFirst();
        }

        [Given(@"the user adds item to cart on products page")]
        public void GivenTheUserAddsItemToCart()
        {
            ProductsPage productsPage = new ProductsPage();
            var element = BaseStep.webDriver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[2]/div[2]/a[1]/span"));
            Actions actions = new Actions(BaseStep.webDriver);
            actions.MoveToElement(element).Perform();
            productsPage.ClickAddToCartButton();
        }

        [When(@"the user clicks on the cart button")]
        public void WhenTheUserClicksOnTheCartButton()
        {
            ProductsPage productsPage = new ProductsPage();
            productsPage.ClickTheCartButton();
        }


        [Then(@"the price in column '([^']*)' corresponds to price of item")]
        public void ThenThePriceInColumnCorrespondsToPriceOfItem(string p0)
        {
            CartsPage cartsPage = new CartsPage();
            var actualPrice = cartsPage.GetTotalPrice();

            Assert.AreEqual(Constants.PriceOfDress, actualPrice, "The price does not corresponds to price of item");
        }

        [Then(@"the name in column '([^']*)' corresponds to price of item")]
        public void ThenTheNameInColumnCorrespondsToPriceOfItem(string description)
        {
            CartsPage cartsPage = new CartsPage();
            var actualNameOfDress = cartsPage.GetNameOfDress();
              

            Assert.AreEqual(Constants.NameOfDress, actualNameOfDress, "Expected and actual are not equal");
        }


        [Given(@"the user presses '([^']*)' button for the first item on the products page")]
        public void GivenTheUserPresesButtonForTheFirstItem(string more)
        {
            Thread.Sleep(3000);
            ProductsPage productsPage = new ProductsPage();
            var moreButton = BaseStep.webDriver.FindElement(By.XPath("//*[@id=\"center_column\"]/ul/li/div/div[2]/div[2]/a[2]/span"));
            Actions actions = new Actions(BaseStep.webDriver);
            actions.MoveToElement(moreButton).Perform();
            productsPage.ClickOnTheButtonMore();
        }

        [Given(@"the user sets parameters for item on TShirts page")]
        public void GivenTheUserSetsParametresForItem(Table table)
        {
            TShirtsPage tShirt = new TShirtsPage();
            tShirt.DeleteDigitFromField();
            tShirt.FeelQuantityField(table.Rows[0]["Quantity"]);
            Thread.Sleep(1000);
            tShirt.ClickDropDown();
            tShirt.SelectSizeL();
            tShirt.ClickWhite();
        }

        [Then(@"the message '([^']*)' is appeared")]
        public void ThenMessageIsAppeared(string successMessage)
        {
            Thread.Sleep(6000);

            TShirtsPage tShirt = new TShirtsPage();
            var actualMessage = tShirt.GetSucessMessage();

            Assert.AreEqual(successMessage, actualMessage, "The success message is NOT displayed");
        }

        [When(@"the user clicks on add to cart button on TShirts page")]
        [Given(@"the user clicks on add to cart button")]
        public void GivenTheUserClicksOnAddToCartButton()
        {
            TShirtsPage tShirt = new TShirtsPage();
            tShirt.ClickAddToCartButton();
        }

        [Given(@"the user clicks '([^']*)' in the popup")]
        public void GivenTheUserClickInPopup(string p0)
        {
            Thread.Sleep(8000);

            TShirtsPage tShirt = new TShirtsPage();
            tShirt.ClickContinueShopping();
        }

        [Given(@"the user deletes '([^']*)' from search-field")]
        public void GivenTheUserDeletesFromSearch_Field(string blouse)
        {
            TShirtsPage tShirt = new TShirtsPage();
            tShirt.DeleteTextFromSearchInput();
        }

        [Given(@"the user sets parameters for item \(adds quantity,color,size\) on TShirts page")]
        public void GivenTheUserSetsParametresForItemAddsQuantityColorSizeOnTShirtsPage(Table table)
        {
            TShirtsPage tShirt = new TShirtsPage();
            tShirt.DeleteDigitFromField();
            tShirt.FeelQuantityField(table.Rows[0]["Quantity"]);
            tShirt.ClickDropDown();
            tShirt.ClickSizeM();
            tShirt.ClickColorOrange();
        }


        [Given(@"the user clicks '([^']*)' button")]
        [When(@"the user clicks '([^']*)' button")]
        public void WhenTheUserClicksButton(string p0)
        {
            Thread.Sleep(7000);

            TShirtsPage tShirt = new TShirtsPage();
            tShirt.ClickProceedToCheckout();
        }

        [Then(@"blouse is displayed with the right parameters")]
        public void ThenEachItemIsDiaplayedWithRightParameters()
        {
            CartsPage cartsPage = new CartsPage();
            var actualBlouse = cartsPage.GetBlouseParametres();

            Assert.AreEqual(Constants.ParamsOfBlouse, actualBlouse, "The blouse does not displayed with right parameters");
        }

        [Then(@"dress is displayed with right parameters")]
        public void ThenDressIsDisplayedWithRightParameters()
        {
            CartsPage cartsPage = new CartsPage();
            var actualDress = cartsPage.GetDressParemeters();

            Assert.AreEqual(Constants.ParamsOfDress, actualDress, "The dress does not displayed with right parameters");
        }

        [Given(@"the user clicks on the delete button")]
        public void GivenTheUserClicksOnTheDeleteButton()
        {
            CartsPage cartsPage = new CartsPage();
            cartsPage.ClickDeleteButton();
        }

        [When(@"the dress does not remains on the page")]
        public void WhenDressIsNotRemainsOnThePage()
        {
            CartsPage cartsPage = new CartsPage();
            cartsPage.CheckThatDresIsNotRemains();
        }

        [Then(@"only a blouse remains in the table")]
        public void ThenOnlyABlouseRemainsInTheTable()
        {
            Thread.Sleep(7000);
            CartsPage cartsPage = new CartsPage();
            var actualBlouseParameters = cartsPage.GetBlouseParametres();

            Assert.AreEqual(Constants.ParamsOfBlouse, actualBlouseParameters, "Blouse is not remains on the page");
        }

        [Given(@"the user clicks on Send to a friend button")]
        public void GivenTheUserClicksOnSendToAFriendButton()
        {
            TShirtsPage tShirts = new TShirtsPage();
            tShirts.ClickSendToFriendButton();
        }

        [Given(@"the user feels Name of friend field")]
        public void GivenTheUserFeelsNameOfFriendField()
        {
            TShirtsPage tShirts = new TShirtsPage();
            tShirts.EnterFriendName();
        }

        [Given(@"the user feels E-mail field")]
        public void GivenTheUserFeelsE_MailField()
        {
            TShirtsPage tShirts = new TShirtsPage();
            tShirts.EnterEmail();
        }

        [When(@"the user clicks Send button")]
        public void WhenTheUserClicksSendButton()
        {
            TShirtsPage tShirts = new TShirtsPage();
            tShirts.ClickSendButton();
        }

        [Then(@"appears success message Your e-mail has been sent successfully")]
        public void ThenAppearsSuccessMessageYourE_MailHasBeenSentSuccessfully()
        {
            Thread.Sleep(6000);

            TShirtsPage tShirts = new TShirtsPage();
            string actualMessageHasBeenSent = tShirts.GetMessageHasBeenSent();

            Assert.AreEqual(Constants.SuccessSendMessage, actualMessageHasBeenSent, "message was not sent");
        }

        [Given(@"the user clicks on Contact Us button on the base page")]
        public void GivenTheUserClicksOnContactUsButtonOnBasePage()
        {
            BasePage basePage = new BasePage();
            basePage.ClickContactUsButton();
        }

        [Given(@"the user choices Customer service in Subject Heading dropdown")]
        public void GivenTheUserChoicesCustomerServiceInSubjectHeadingDropdown()
        {
            ContactPage contactPage = new ContactPage();
            contactPage.ClickCustomerServiceButton();
        }

        [Given(@"the user feels the Email address field")]
        public void GivenTheUserFeelsEmailAdressField()
        {
            ContactPage contactPage = new ContactPage();
            contactPage.FeelEmailAddressField();
        }

        [Given(@"the user feels the Order reference field")]
        public void GivenTheUserFeelsOrderReferenceField()
        {
            ContactPage contactPage = new ContactPage();
            contactPage.FeelOrderReferenceField();
        }

        [Given(@"the user feels text area message")]
        public void GivenTheUserFeelsTextAreaMessage()
        {
            ContactPage contactPage = new ContactPage();
            contactPage.FeelTextAreaMessage();
        }

        [When(@"the user clicks on the Send button")]
        public void WhenTheUserClicksOnSendButton()
        {
            ContactPage contactPage = new ContactPage();
            contactPage.ClickSendButtonOnContactPage();
        }

        [Then(@"success message is displayed")]
        public void ThenSuccessMessageIsDisplayed()
        {
            ContactPage contactPage = new ContactPage();
            var actualSuccessMessageOnContact = contactPage.GetSuccessMessageOnContactPage();

            Assert.AreEqual(Constants.SuccessMessageOnContactPage, actualSuccessMessageOnContact, "Success message is not displayed");
        }

        [When(@"the user enters email in Newsletter field")]
        public void WhenTheUserEntersEmailInNewsletterField()
        {
            BasePage basePage = new BasePage();
            var newsLetterField = BaseStep.webDriver.FindElement(By.Id("newsletter-input"));
            Actions actions = new Actions(BaseStep.webDriver);
            actions.MoveToElement(newsLetterField).Perform();
            basePage.EnterEmailInNewsLetterField();
            basePage.PressEnter();
        }

        [Then(@"success message has appeared")]
        public void ThenSuccessMessageIsAppeared()
        {
            BasePage basePage = new BasePage();
            var actualSuccessMessageNewsLetter = basePage.GetSuccessMessageNewsLetter();

            Assert.AreEqual(Constants.SuccessMessageNewsLetter, actualSuccessMessageNewsLetter, "The success message is not appeared");
        }


    }
}




