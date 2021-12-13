using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjects;
using POMTask.Constants;

namespace Tests
{
    public class Program
    {
        protected static IWebDriver driver;
 
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }
        static void Main(string[] args)
        {
        }

        [Test]
        public void CheckNegativeLogin()
        {
            LoginPage login = new LoginPage();
            login.EnterEmail();
            login.EnterPassword();
            login.ClickSignInButton();
            string actualError = login.GetErrorMessage();
            string expectedError = "Authentication failed.";

            Assert.AreEqual(expectedError, actualError, $"{expectedError} is not equal to {actualError}");
        }

        [Test]
        public void GetButtonCreate()
        {
            LoginPage login = new LoginPage();
            string btnCreate = login.GetButtonCreate();
            Console.WriteLine(btnCreate);

            Assert.AreEqual(Constant.titleCreate, btnCreate, $"Text {btnCreate} is NOT as expected");
        }

        [Test]
        public void GetTitleAlreadyRegistered()
        {
            LoginPage login = new LoginPage();
            string titleAlreadyRegistered = login.GetTitleAlreadyRegistered();
            Console.WriteLine(titleAlreadyRegistered);

            Assert.AreEqual(Constant.txtAlreadyRegistered, titleAlreadyRegistered, "");
        }

        [Test]
        public void GetTitlePleaseEnterEmail()
        {
            LoginPage login = new LoginPage();
            string paragraphPlsEnterEmail = login.GetTitlePleaseEnterEmail();
            Console.WriteLine(paragraphPlsEnterEmail);
            
            Assert.AreEqual(Constant.msgPleaseEnter, paragraphPlsEnterEmail, $"The pagraph {paragraphPlsEnterEmail} is NOT found");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}


