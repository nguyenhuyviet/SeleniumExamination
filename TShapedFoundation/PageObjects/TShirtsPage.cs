using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TShapedFoundation.Common;
using TShapedFoundation.DTO;
using System.Linq;

namespace TShapedFoundation.PageObjects
{
    class TShirtsPage : ProductPage
    {
        private By bySearchTop = By.Id("search_query_top");
        private By bySubmitSearch = By.Name("submit_search");

        public TShirtsPage(IWebDriver driver) : base(driver)
        {
        }

        public SearchResultPage SearchTop(string query)
        {
            WaitForElementVisible(bySearchTop);
            SendKeyToElement(bySearchTop, query);
            ClickToElement(bySubmitSearch);
            return new SearchResultPage(driver);
        }
    }
}
