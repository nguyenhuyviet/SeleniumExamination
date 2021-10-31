using OpenQA.Selenium;
using System;
using TShapedFoundation.Common;

namespace TShapedFoundation.PageObjects
{
    class SignInPage : BasePage
    {
        private By byEmailCreate = By.Id("email_create");
        private By bySubmitCreate = By.Id("SubmitCreate");

        public SignInPage(IWebDriver driver) : base(driver)
        {
        }

        public CreateAnAccountPage GoToCreateAnAccounPagetWithEmail(string email)
        {
            WaitForElementVisible(byEmailCreate);
            SendKeyToElement(byEmailCreate, email);
            ClickToElement(bySubmitCreate);
            return new CreateAnAccountPage(driver);
        }
    }
}
