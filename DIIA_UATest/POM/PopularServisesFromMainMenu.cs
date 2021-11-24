using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DIIA_UATest.POM
{
    class PopularServisesFromMainMenu
    {
        private readonly IWebDriver _webDriver;
        private readonly Actions _action;

        public PopularServisesFromMainMenu(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _action = new Actions(_webDriver);
        }

        private readonly By _clickRightButton = By.CssSelector("[class='swiper_services-btn-next swiper-btn-next']");
        private readonly By _clikLeftButton = By.CssSelector("[class='swiper_services-btn-prev swiper-btn-prev']");
        private readonly By _movedOneRight = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[2]/div[5]/div[1]/div/a");
        private readonly By _movedOneLeft = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[2]/div[4]/div[1]/div/a");
        private readonly By _swipeLeft = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[3]/span[1]");
        private readonly By _swipeRight = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[3]/span[2]");
        private readonly By _clickToPopularServises = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[2]/div[1]/div[1]/div/a");
        private readonly By _goToPopularServises = By.XPath("//*[@id='layout-main']/section[1]/div[1]/div/div[3]");

        public PopularServisesFromMainMenu SwipeToTheRightClick()
        {
            _webDriver.FindElement(_swipeRight).Click();
            return this;
        }

        public PopularServisesFromMainMenu SwipeToTheLeftClick()
        {
            _webDriver.FindElement(_swipeLeft).Click();
            return this;
        }

        public PopularServisesFromMainMenu ClickToTheRightSide()
        {
            _webDriver.FindElement(_clickRightButton).Click();
            return this;
        }

        public PopularServisesFromMainMenu ClickToTheLeftSide()
        {
            _webDriver.FindElement(_clikLeftButton).Click();
            return this;
        }

        public void ClickToPopularServicePage(string servisePage) =>
           _action.MoveToElement( _webDriver.FindElement(_clickToPopularServises)).Click().Perform();

        public string GoToToPopularServicePage() =>
            _webDriver.FindElement(_goToPopularServises).Text;

        public bool MovedToTheRight() =>
            _webDriver.FindElement(_movedOneRight).GetAttribute("class").Contains("active");

        public string MovedToTheLeft() =>
            _webDriver.FindElement(_movedOneLeft).Text;
    }
}
