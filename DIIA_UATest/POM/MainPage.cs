using OpenQA.Selenium;

namespace DIIA_UATest.POM
{
    class MainPage
    {
        private readonly IWebDriver _webDriver;

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _cookieClose = By.CssSelector("[class = 'cookies-1_close']");


        public MainPage GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

        public MainPage CloseCookie()
        {
            _webDriver.FindElement(_cookieClose).Click();
            return this;
        }
    }
}
