using OpenQA.Selenium;

namespace DIIA_UITest.POM
{
    class PopularServisesFromMainMenu
    {
        private readonly IWebDriver _webDriver;

        public PopularServisesFromMainMenu(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _clickRightButton = By.CssSelector("[class='swiper_services-btn-next swiper-btn-next']");
        private readonly By _clikLeftButton = By.CssSelector("[class='swiper_services-btn-prev swiper-btn-prev']");
        private readonly By _movedOneRight = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[2]/div[5]/div[1]/div/a");
        private readonly By _movedOneLeft = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[2]/div[4]/div[1]/div/a");
        private readonly By _cookieClose = By.CssSelector("[class='cookies-1_close']");
        private readonly By _swipeLeft = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[3]/span[1]");
        private readonly By _swipeRight = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[3]/span[2]");

        public PopularServisesFromMainMenu SwipeToTheRightClick()
        {
            _webDriver.FindElement(_swipeRight).Click();
            return this;
        }

        public PopularServisesFromMainMenu SwipeToTheLeftClick()
        {
            _webDriver.FindElement(_swipeRight).Click();
            _webDriver.FindElement(_swipeLeft).Click();
            _webDriver.FindElement(_cookieClose).Click();
            return this;
        }

        public PopularServisesFromMainMenu ClickToTheRightSide()
        {
            _webDriver.FindElement(_clickRightButton).Click();
            return this;
        }

        public PopularServisesFromMainMenu ClickToTheLeftSide()
        {
            _webDriver.FindElement(_clickRightButton).Click();
            _webDriver.FindElement(_clikLeftButton).Click();
            _webDriver.FindElement(_cookieClose).Click();
            return this;
        }

        public PopularServisesFromMainMenu GoToPopularServicePage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/services/covid19-sertifikat-pro-vakcinaciyu");
            return this;
        }

        public void MovedToTheRight()
        {
            _webDriver.FindElement(_movedOneRight);
        }

        public void MovedToTheLeft()
        {
            _webDriver.FindElement(_movedOneLeft);
        }
    }
}
