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

        [Test]
        public void NegativeLogin()
        {
            LoginPage login = new LoginPage();
            login.SendTextToEmail("wasdas@gmai");
            login.SendTextToPassword("summer123");
            login.ClickSignInBtn();
            string actualError = login.GetErrorMessage();
            string expectedError = "Invalid email address.";

            Assert.AreEqual(expectedError, actualError, $"{expectedError} is not equal to {actualError}");

        }

        [Test]
        public void GetButtonCreate()
        {
            LoginPage login = new LoginPage();
            string btnCreate = login.GetTextBtnCreate();
            Console.WriteLine(btnCreate);

            Assert.AreEqual(Constant.titleCreate, btnCreate, $"Text {btnCreate} is NOT as expected");
        }

        [Test]
        public void GetTitleAlreadyRegistered()
        {
            LoginPage login = new LoginPage();
            string titleAlreadyRegistered = login.GetTextAlreadyRegistered();
            Console.WriteLine(titleAlreadyRegistered);

            Assert.AreEqual(Constant.txtAlreadyRegistered, titleAlreadyRegistered, "");
        }

        [Test]
        public void VerifyParagraphPlsEnterEmail()
        {
            LoginPage login = new LoginPage();
            string paragraphPlsEnterEmail = login.GetTextPlsEnterEmail();
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


