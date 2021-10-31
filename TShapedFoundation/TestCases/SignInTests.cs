using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TShapedFoundation.Common;
using TShapedFoundation.PageObjects;
using FluentAssertions;
using TShapedFoundation.DTO;

namespace TShapedFoundation.TestCases
{
    [TestFixture]
    class SignInTests : WebDriverManagers
    {
        IWebDriver driver;
        HomePage homePage;
        

        [SetUp]
        public void Setup()
        {
            driver = CreateBrowserDriver("chrome");
            driver.Navigate().GoToUrl(Common.Constant.APP_URL);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void SignInSuccessfully()
        {
            homePage = new HomePage(driver);
            SignInPage signInPage = homePage.ClickSignIn();
            CreateAnAccountPage createAnAccountPage = signInPage.GoToCreateAnAccounPagetWithEmail(GetUniqueEmail());
            var customerInfomation = new CustomerInformation()
            {
                PersonalInformation = new PersonalInformation()
                {
                    FirstName = "Harry",
                    LastName = "Potter",
                    Password = "12345"
                },
                AddressInformation = new AddressInformation()
                {
                    FirstName = "Harry",
                    LastName = "Potter",
                    Address = "abc",
                    City = "City",
                    State = "Alaska",
                    PostalCode = "00000",
                    Country = "United States",
                    Alias = "viet01",
                    MobilePhone = "0123",
                    HomePhone = "1234"
                }
            };
            MyAccountPage myAccountPage = createAnAccountPage.CreateAnAccount(customerInfomation);
            var pageHeadingInMyAccoutPage = myAccountPage.GetPageHeadingText();

            pageHeadingInMyAccoutPage.Should().Be("MY ACCOUNT", "User is created because we have been in My Account page.");
        }

        private string GetUniqueEmail()
        {
            var guid = Guid.NewGuid();
            return string.Format(Constant.EMAIL_FORMAT, guid);
        }
    }
}
