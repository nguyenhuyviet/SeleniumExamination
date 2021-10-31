using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TShapedFoundation.Common;
using TShapedFoundation.DTO;

namespace TShapedFoundation.PageObjects
{
    class CreateAnAccountPage : BasePage
    {
        private By byCustomerFirstName = By.Id("customer_firstname");
        private By byCustomerLastName = By.Id("customer_lastname");
        private By byPassword = By.Id("passwd");
        private By byFirstName = By.Id("firstname");
        private By byLastName = By.Id("lastname");
        private By byAddress1 = By.Id("address1");
        private By byCity = By.Id("city");
        private By byState = By.Id("id_state");
        private By byPostcode = By.Id("postcode");
        private By byCountry = By.Id("id_country");
        private By byHomePhone = By.Id("phone");
        private By byMobile = By.Id("phone_mobile");
        private By byAlias = By.Id("alias");
        private By bySubmitAccount = By.Id("submitAccount");

        public CreateAnAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public MyAccountPage CreateAnAccount(CustomerInformation customerInformation)
        {
            WaitForElementVisible(byCustomerFirstName);
            SendKeyToElement(byCustomerFirstName, customerInformation.PersonalInformation.FirstName);
            SendKeyToElement(byCustomerLastName, customerInformation.PersonalInformation.LastName);
            SendKeyToElement(byPassword, customerInformation.PersonalInformation.Password);
            SendKeyToElement(byFirstName, customerInformation.AddressInformation.FirstName);
            SendKeyToElement(byLastName, customerInformation.AddressInformation.LastName);
            SendKeyToElement(byAddress1, customerInformation.AddressInformation.Address);
            SendKeyToElement(byCity, customerInformation.AddressInformation.City);
            SendKeyToElement(byPostcode, customerInformation.AddressInformation.PostalCode);
            SendKeyToElement(byHomePhone, customerInformation.AddressInformation.HomePhone);
            SendKeyToElement(byMobile, customerInformation.AddressInformation.MobilePhone);
            SendKeyToElement(byAlias, customerInformation.AddressInformation.Alias);
            SelectItemForDropdownByText(byState, customerInformation.AddressInformation.State);
            SelectItemForDropdownByText(byCountry, customerInformation.AddressInformation.Country);
            ClickToElement(bySubmitAccount);
            return new MyAccountPage(driver);
        }
    }
}
