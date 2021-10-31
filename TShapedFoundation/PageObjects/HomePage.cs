using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TShapedFoundation.Common;

namespace TShapedFoundation.PageObjects
{
    class HomePage : BasePage
    {
        private By bySignIn = By.ClassName("login");
        private By category(string category) => By.XPath("//a[@title='" + category + "']");
        private By subMenuInCategory(string category, string menu) => By.XPath("//a[@title='" + category + "']/..//a[@title='"+ menu +"']");

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public TShirtsPage ClickSubMenuInCategory(string categoryName, string menuName)
        {
            ClickChildElementInHoveredParentElement(category(categoryName), subMenuInCategory(categoryName, menuName));
            return new TShirtsPage(driver);
        }

        public SignInPage ClickSignIn()
        {
            var signInUrl = GetElementAttribute(bySignIn, "href");
            OpenUrl(signInUrl);
            return new SignInPage(driver);
        }
    }
}
