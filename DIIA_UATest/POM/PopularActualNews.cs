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
            return this;
        }

        public PopularActualNews ClikPreviousPageButton()
        {
            _webDriver.FindElement(_clikNextPageButton).Click();
            _webDriver.FindElement(_clikPreviousPageButton).Click();
            return this;
        }

        public void ClickToSelectedNews(string firstNews) =>
            _webDriver.FindElement(_clickOnSelectedNews).Click();

        public PopularActualNews GoToSelectedNewsPage()
        {
            _webDriver.FindElement(_goToSelectedNewsPage);
            return this;
        }
            
        public bool SeeAActivePlaginationNextPage() =>
            _webDriver.FindElement(_plaginationNext).GetAttribute("class").Contains("active");
          
        public bool SeeAActivePlaginationPreviousPage() =>
            _webDriver.FindElement(_plaginationPrevious).GetAttribute("class").Contains("active");       
    }
}
