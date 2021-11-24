using OpenQA.Selenium;

namespace DIIA_UATest.POM
{
    class PopularActualNews
    {
        private readonly IWebDriver _webDriver;
        private readonly MainPage _mainPage;

        public PopularActualNews(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _mainPage = new MainPage(_webDriver);
        }

        public PopularActualNews GoToNewsPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/news");
            return this;
        }

        private readonly By _clickMoreNewsButton = By.CssSelector("[class='btn btn_more-news']");
        private readonly By _clikNextPageButton = By.CssSelector("[id='post-navigation'] [rel='next']");
        private readonly By _clikPreviousPageButton = By.CssSelector("[id='post-navigation'] [rel='prev']");
        private readonly By _plaginationNext = By.XPath("//*[@id='post-navigation']/ul/li[3]/span");
        private readonly By _plaginationPrevious = By.XPath("//*[@id='post-navigation']/ul/li[3]/span");
        private readonly By _clickOnSelectedNews = By.XPath("//*[@id='posts-items-box']/div[1]/div/a[2]");
        private readonly By _goToSelectedNewsPage = By.XPath("//*[@id='layout-main']/section[1]/div/div[1]/div/div/div[1]");

        public PopularActualNews СlickMoreNewsButton()
        {
            _webDriver.FindElement(_clickMoreNewsButton).Click();
            return this;
        }

        public PopularActualNews СlikNextPageButton()
        {
            _webDriver.FindElement(_clikNextPageButton).Click();
            _mainPage.CloseCookie();
            return this;
        }

        public PopularActualNews ClikPreviousPageButton()
        {
            СlikNextPageButton();
            _webDriver.FindElement(_clikPreviousPageButton).Click();
            return this;
        }

        public PopularActualNews ClickToSelectedNews(string firstNews)
        {
            _webDriver.FindElement(_clickOnSelectedNews).Click();
            return this;
        }

         public string GoToSelectedNewsPage(string select) =>
            _webDriver.FindElement(_goToSelectedNewsPage).Text;
 
        public string SeeAActivePlaginationNextPage() =>
            _webDriver.FindElement(_plaginationNext).Text;

        public string SeeAActivePlaginationPreviousPage() =>
            _webDriver.FindElement(_plaginationPrevious).Text;
    }
}