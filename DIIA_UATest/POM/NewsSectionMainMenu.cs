using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace DIIA_UATest.POM
{
    class NewsSectionMainMenu
    {
        private readonly IWebDriver _webDriver;
        private readonly Actions _action;

        public NewsSectionMainMenu(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _action = new Actions(_webDriver);
        }

        private readonly By _clickOnAllNewsButton = By.XPath("//*[@id='layout-main']/section[4]/div/div[1]/div[2]/div/a/span");
        private readonly By _clickOnSelectedNewsTitle = By.XPath("//*[@id='layout-main']/section[4]/div/div[2]/div[2]/div/div[3]/div/div/a");
        private readonly By _goToSelectedNews = By.XPath("//*[@id='layout-main']/section[1]/div/div[1]/div/div/div[1]");
        private readonly By _goToAllNewsPage = By.XPath("//*[@id='posts-container']/div[1]/div/h1");

        public void ClickAllNewsPageButton() =>
           _action.MoveToElement(_webDriver.FindElement(_clickOnAllNewsButton)).Click().Perform();

        public void ClickToSelectedNewsTitle(string title) =>
         _action.MoveToElement(_webDriver.FindElement(_clickOnSelectedNewsTitle)).Click().Perform();

        public string GoToSelectedNews(string selectedNews)
        {
            return _webDriver.FindElement(_goToSelectedNews).Text;  
        }

        public string GoToAllNewsPage(string newsPage)
        {
           return _webDriver.FindElement(_goToAllNewsPage).Text;
        }
    }
}