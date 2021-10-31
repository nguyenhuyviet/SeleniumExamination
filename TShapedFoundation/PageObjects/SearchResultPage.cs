using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TShapedFoundation.Common;
using TShapedFoundation.DTO;
using System.Linq;

namespace TShapedFoundation.PageObjects
{
    class SearchResultPage : ProductPage
    {
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
