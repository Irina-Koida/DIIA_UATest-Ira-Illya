using OpenQA.Selenium;
using System;

namespace DIIA_UATest.POM
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
        private readonly By _swipeLeft = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[3]/span[1]");
        private readonly By _swipeRight = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[3]/span[2]");
        private readonly By _clickToPopularServises = By.XPath("//*[@id='gromadyanam']/div[1]/div/div[2]/div[1]/div[1]/div/a");
        private readonly By _goToPopularServises = By.XPath("//*[@id='layout-main']/section[1]/div[1]/div/div[3]/div[1]");

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

        public void ClickToPopularServicePage(string servises) =>
            _webDriver.FindElement(_clickToPopularServises).Click();
        
        public PopularServisesFromMainMenu GoToToPopularServicePage()
        {
            _webDriver.FindElement(_goToPopularServises);
            return this;
        }
        
        public bool MovedToTheRight() =>
            _webDriver.FindElement(_movedOneRight).GetAttribute("class").Contains("active"); 
          
        public bool MovedToTheLeft() =>
            _webDriver.FindElement(_movedOneLeft).GetAttribute("class").Contains("active");   
    }
}
