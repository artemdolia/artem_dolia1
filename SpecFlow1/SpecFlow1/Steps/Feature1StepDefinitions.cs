using System.Linq;
using System.Threading;
using NUnit.Framework;
using SpecFlow1.Constant;
using SpecFlow1.Pages;
using SpecFlowTask3.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowTask3.Steps
{
    [Binding]
    public class Feature1StepDefinitions
    {
        static void Main()
        {
        }

        [Given(@"the user enters '([^']*)' in search-field on the base page")]
        public void GivenTheUserEntersSummerInInput_Field(string valueOfSearch)
        {
            BasePage basePage = new BasePage();
            basePage.EnterText(valueOfSearch);
        }

        [When(@"the user clicks on search button")]
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

            Assert.IsTrue(summerDisplayed);
        }

        [Given(@"the user clicks on search button")]
        public void GivenTheUserClicksOnSearchButton()
        {
            BasePage basePage = new BasePage();
            basePage.ClickOnSearch();
        }

        [When(@"the user choices option Price: Highest first on products page")]
        public void WhenTheUserChoicesOptionPriceHighestFirst()
        {
            ProductsPage productsPage = new ProductsPage();
            productsPage.ClickOptionHighestFirst();
        }

        [Then(@"sorting is performed from high price to low on products page")]
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
            var expectedPriceOfDress = Constanta.priceOfDress;

            Assert.AreEqual(expectedPriceOfDress, actualPrice, "");
        }

        [Then(@"the name in column '([^']*)' corresponds to price of item")]
        public void ThenTheNameInColumnCorrespondsToPriceOfItem(string description)
        {
            CartsPage cartsPage = new CartsPage();
            var actualNameOfDress = cartsPage.GetNameOfDress();
            var expectedNameOfDress = Constanta.nameOfDress;

            Assert.AreEqual(expectedNameOfDress, actualNameOfDress, "Expected and actual are not equal");
        }


        [Given(@"the user preses '([^']*)' button for the first item on products page")]
        public void GivenTheUserPresesButtonForTheFirstItem(string more)
        {
            ProductsPage productsPage = new ProductsPage();
            productsPage.ClickOnTheButtonMore();
        }

        [Given(@"the user sets parametres for item on TShirts page")]
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

        [Given(@"the user clicks '([^']*)' in popup")]
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

        [Given(@"the user sets parametres for item \(adds quantity,color,size\) on TShirts page")]
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

        [Then(@"blouse is displayed with right parameters")]
        public void ThenEachItemIsDiaplayedWithRightParametres()
        {
            CartsPage cartsPage = new CartsPage();
            var actualBlouse = cartsPage.GetBlouseParametres();
            var expectedBlouseParameters = Constanta.paramsOfBlouse;

            Assert.AreEqual(expectedBlouseParameters, actualBlouse, "");
        }

        [Then(@"dress is displayed with right parameters")]
        public void ThenDressIsDisplayedWithRightParameters()
        {
            CartsPage cartsPage = new CartsPage();
            var actualDress = cartsPage.GetDressParemeters();
            var expectedDressParameters = Constanta.paramsOfDress;

            Assert.AreEqual(expectedDressParameters, actualDress, "");
        }

        [Given(@"the user clicks on the delete button")]
        public void GivenTheUserClicksOnTheDeleteButton()
        {
            CartsPage cartsPage = new CartsPage();
            cartsPage.ClickDeleteButton();
        }

        [When(@"dress is not remains on the page")]
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
            var expectedBlouseParameters = Constanta.paramsOfBlouse;

            Assert.AreEqual(expectedBlouseParameters, actualBlouseParameters, "Blouse is not remains on the page");
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
            var expectedMessage = Constanta.successSendMessage;

            Assert.AreEqual(expectedMessage, actualMessageHasBeenSent, "");
        }





    }
}




