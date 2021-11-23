﻿using OpenQA.Selenium;

namespace DIIA_UATest.POM
{
    public class SearchFromMainMenu
    {
        private readonly IWebDriver _webDriver;

        public SearchFromMainMenu(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _clickOnSeachInformationField = By.CssSelector("[class='input form-search_input']");
        private readonly By _clikOnSearchInfoButton = By.CssSelector("[type='submit']");
        private readonly By _searchRequestTextInfo = By.CssSelector("[class ='search_request-text']");

        public void InputOnSearchInformationField(string input) =>
            _webDriver.FindElement(_clickOnSeachInformationField).SendKeys(input);
        
        public void ClickOnSearchInformationField() =>
            _webDriver.FindElement(_clikOnSearchInfoButton).Click();
        
        public string SearchInfoRequestText() =>
            _webDriver.FindElement(_searchRequestTextInfo).Text;
    }
}
