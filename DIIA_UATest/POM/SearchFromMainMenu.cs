using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DIIA_UATest.POM
{
    public class SearchFromMainMenu
    {
        private readonly IWebDriver _webDriver;
        private readonly Actions _action;

        public SearchFromMainMenu(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _action = new Actions(_webDriver);
        }

        private readonly By _clickOnSeachInformationField = By.CssSelector("[class='input form-search_input']");
        private readonly By _clikOnSearchInfoButton = By.CssSelector("[type='submit']");
        private readonly By _searchRequestTextInfo = By.CssSelector("[class ='search_request-text']");
        private readonly By _searchRequestTextInfoInvalid = By.XPath("//*[@id='search_request-text'] ");

        public void InputOnSearchInformationField(string input) =>
            _webDriver.FindElement(_clickOnSeachInformationField).SendKeys(input);
        
        public void ClickOnSearchInformationField()
        {
            _action.MoveToElement(_webDriver.FindElement(_clikOnSearchInfoButton)).Click().Perform();
        }
      
        public string SearchInfoRequestText()
        {
            return _webDriver.FindElement(_searchRequestTextInfo).Text;
        }

        public string SearchInfoRequestText(string invalid) =>
                _webDriver.FindElement(_searchRequestTextInfoInvalid).Text;
        
    }
}
