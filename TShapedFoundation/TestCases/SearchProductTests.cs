using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TShapedFoundation.Common;
using TShapedFoundation.PageObjects;
using FluentAssertions;

namespace TShapedFoundation.TestCases
{
    [TestFixture]
    class SearchProductTests : WebDriverManagers
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
        public void SearchedProductShouldHasSameDetailsLikeTShirtsPage()
        {
            homePage = new HomePage(driver);
            TShirtsPage tShirtsPage = homePage.ClickSubMenuInCategory("Women", "T-shirts");
            var productDetailsInTShirtsPage = tShirtsPage.GetProductDetails();
            SearchResultPage searchResultPage = tShirtsPage.SearchTop(productDetailsInTShirtsPage.Name);
            var productDetailsInSearchResultPage = searchResultPage.GetProductDetails();
            productDetailsInSearchResultPage.Should().BeEquivalentTo(productDetailsInSearchResultPage);
        }        
    }
}
