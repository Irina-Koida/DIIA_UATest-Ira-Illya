using OpenQA.Selenium;

namespace DIIA_UATest.POM
{
    class NewsSectionMainMenu
    {
        private readonly IWebDriver _webDriver;

        public NewsSectionMainMenu(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


        private readonly By _clickOnAllNewsButton = By.XPath("//*[@id='layout - main']/section[4]/div/div[1]/div[2]/div/a/span");
        private readonly By _clickOnSelectedNewsTitle = By.CssSelector("[class = 'search_request - text']");

        public void ClickAllNewsPageButton()
        {
            _webDriver.FindElement(_clickOnAllNewsButton).Click();

        }

        public void GoToSelectedNews()
        {
            _webDriver.FindElement(_clickOnSelectedNewsTitle).Click();
        }

        public void GoToAllNewsPage()
        {
            _webDriver.FindElement(_clickOnAllNewsButton).Click();

        }
    }
}
