using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;

namespace HomePage1Tests
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _bestSeller = By.XPath("//a[@class='blockbestsellers']");
        private readonly By _activeButton = By.XPath("//li[@class='active']/a[text()='Best Sellers']");
        private readonly By _searchName = By.XPath("//input[@name='search_query']");
        private readonly By _shirtResult = By.XPath("//span[@class='lighter']");
        private readonly By _tabsList = By.XPath("//*[@id='block_top_menu']/ul");
       // private readonly By _tabOfPage = By.XPath("/html/head/title");
       // private readonly By _tabOfPage1 = By.CssSelector("#block_top_menu > ul > li:nth-child(1)");
      //  private readonly By _tabOfPage2 = By.CssSelector("#block_top_menu > ul > li:nth-child(2)");
       // private readonly By _tabOfPage3 = By.CssSelector("#block_top_menu > ul > li:nth-child(3)");
        


        private const string _expectedButton = "BEST SELLERS";
        private const string _expectedResult = "SHIRT";
        private const string _nameOfArea = "Search";
        private const string _emptystring = "<string.Empty>";



        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://automationpractice.com/");

        }

        [Test]
        public void ClickOnTheBestSellerButtons()
        {
            var bestSel = driver.FindElement(_bestSeller);
            bestSel.Click();
            var activeButton = driver.FindElement(_activeButton).Text;

            Assert.AreEqual(_expectedButton, activeButton, "button is not found");

        }


        [Test]
        public void EnterTheText()
        {
            var search = driver.FindElement(_searchName);
            search.SendKeys(_expectedResult);
            search.SendKeys(Keys.Enter);
            var result = driver.FindElement(_shirtResult).Text;

            Assert.AreEqual(_expectedResult, result.Trim('"'), "");
        }

        [Test]
        public void SelectTabs()
        {
            var tabs = driver.FindElement(_tabsList).Text;
            tabs = tabs.Replace("\r\n", " ");
            string mainTab = $"WOMEN\r\nDRESSES\r\nT-SHIRTS";
            mainTab = mainTab.Replace("\r\n", " ");

            Console.WriteLine($"{mainTab}");

          Assert.AreEqual(tabs, mainTab, "");

            //var tabs = driver.FindElements(_tabsList);

            //foreach (var tab in tabs)

            //{
                
            //    Console.WriteLine($"{tab.Text}");
            //}

    
        }
        [Test]
        public void GetVallueOfVallueSearch()
        {
            var searchArea = driver.FindElement(_searchName).GetAttribute("name");
            Console.WriteLine($"{searchArea}");

            Assert.AreEqual(searchArea, "search_query");

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

