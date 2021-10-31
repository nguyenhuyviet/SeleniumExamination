using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TShapedFoundation.Common;
using TShapedFoundation.DTO;

namespace TShapedFoundation.PageObjects
{
    class MyAccountPage : BasePage
    {
        private By byPageHeading = By.ClassName("page-heading");

        public MyAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetPageHeadingText()
        {
            WaitForElementVisible(byPageHeading);
            return GetElementText(byPageHeading);
        }
    }
}
