using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TShapedFoundation.Common;
using TShapedFoundation.DTO;
using System.Linq;

namespace TShapedFoundation.PageObjects
{
    class ProductPage : BasePage
    {
        private protected By byProductName = By.XPath("//div[@class='right-block']//a[@class='product-name']");
        private protected By byProductPrice = By.XPath("//div[@class='right-block']//span[@class='price product-price']");
        private protected By byProductAvailability = By.XPath("//div[@class='right-block']//span[@class='availability']/span");
        private protected By byColorPick = By.ClassName("color_pick");

        public ProductPage(IWebDriver driver) : base(driver)
        {
        }

        public ProductDetails GetProductDetails()
        {
            WaitForElementVisible(byProductName);

            var productDetails = new ProductDetails();
            productDetails.Name = GetElementText(byProductName);
            productDetails.Price = GetElementText(byProductPrice);
            productDetails.Availability = GetElementAttribute(byProductAvailability, "class");
            productDetails.Colors = FindElements(byColorPick).Select(e => e.GetAttribute("id"));

            return productDetails;
        }
    }
}
