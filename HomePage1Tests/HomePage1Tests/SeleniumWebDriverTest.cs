using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;

namespace HomePage1Tests
{
    public class Tests
    {
        private IWebDriver? driver;
        private readonly By _bestSeller = By.XPath("//*[@id='home-page-tabs']/li[2]/a");
        private readonly By _activeButton = By.XPath("//li[@class='active']/a[@class ['blockbestsellers']]");
        private readonly By _searchName = By.XPath("//input[@name='search_query']");
        private readonly By _shirtResult = By.XPath("//span[@class='lighter']");
        private readonly By _tabsList = By.XPath("//*[@id='block_top_menu']/ul");


        private const string _expectedButton = "BEST SELLERS";
        private const string _expectedResult = "SHIRT";
        private const string _nameOfAttribute = "search_query";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://automationpractice.com/index.php");
        }

        [Test]
        public void ClickOnTheBestSellerButtons()
        {
            var bestSel = driver.FindElement(_bestSeller);
            bestSel.Click();
            var activeButton = driver.FindElement(_activeButton).Text;

            Assert.AreEqual(_expectedButton, activeButton, "button is not clickable");
        }

        [Test]
        public void FindTheItemOnThePage()
        {
            var search = driver.FindElement(_searchName);
            search.SendKeys(_expectedResult);
            search.SendKeys(Keys.Enter);
            var result = driver.FindElement(_shirtResult).Text;

            Assert.AreEqual(_expectedResult, result.Trim('"'), "The item 'shirt 'is not found");
        }

        [Test]
        public void SelectTabs()
        {
            string mainTab = $"WOMEN DRESSES T-SHIRTS";

            var tabs = driver.FindElement(_tabsList).Text;
            tabs = tabs.Replace("\r\n", " ");
            mainTab = mainTab.Replace("\r\n", " ");

            Console.WriteLine($"{mainTab}");

            Assert.AreEqual(mainTab, tabs, $"The element 'tab' is not found");
        }

        [Test]
        public void GetVallueOfVallueSearch()
        {
            var searchArea = driver.FindElement(_searchName).GetAttribute("name");
            Console.WriteLine($"{searchArea}");

            Assert.AreEqual(_nameOfAttribute, searchArea, "The vallue of attribute is not found");
        }

        [Test]
        public void TitleOfThePage()
        {
            string title = driver.Title;

            Console.WriteLine($"{title}");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}

