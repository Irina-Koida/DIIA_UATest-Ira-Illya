using OpenQA.Selenium;

namespace DIIA_UATest.POM
{
    class PopularActualNews
    {
        private readonly IWebDriver _webDriver;

        public PopularActualNews(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public PopularActualNews GoToNewsPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/news");
            return this;
        }

        private readonly By _clickMoreNewsButton = By.CssSelector("[class='btn btn_more-news']");
        private readonly By _clikNextPageButton = By.CssSelector("[id='post-navigation'] [rel='next']");
        private readonly By _clikPreviousPageButton = By.XPath("//*[@id='post-navigation']/ul/li[1]/a");
        private readonly By _plaginationNext = By.XPath(".//*[@id='post-navigation']/ul/li[3]/span");
        private readonly By _plaginationPrevious = By.XPath("//*[@id='post-navigation']/ul/li[2]/a");
        private readonly By _cookieClose = By.CssSelector("[class = 'cookies-1_close']");

        public PopularActualNews СlickMoreNewsButton()
        {
            _webDriver.FindElement(_clickMoreNewsButton).Click();
            return this;
        }

        public PopularActualNews СlikNextPageButton()
        {
            _webDriver.FindElement(_clikNextPageButton).Click();
            return this;
        }

        public PopularActualNews ClikPreviousPageButton()
        {
            _webDriver.FindElement(_clikNextPageButton).Click();
            _webDriver.FindElement(_cookieClose).Click();
            _webDriver.FindElement(_clikPreviousPageButton).Click();
            return this;
        }

        public PopularActualNews GoToSelectNewsPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/news/yak-cifrovizaciya-budivelnih-poslug-na-portali-diya-boretsya-z-korupciyeyu-rezultati-opituvannya");
            return this;
        }

        public void SeeAActivePlaginationNextPage()
        {
            _webDriver.FindElement(_plaginationNext);
        }

        public void SeeAActivePlaginationPreviousPage()
        {
            _webDriver.FindElement(_plaginationPrevious);
        }
    }
}
