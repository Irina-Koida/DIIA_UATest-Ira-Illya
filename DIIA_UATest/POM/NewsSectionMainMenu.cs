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
        private readonly By _clickOnSelectedNewsTitle = By.XPath("//*[@id='layout - main']/section[4]/div/div[2]/div[1]/div/div[2]/a");
        private readonly By _goToSelectedNews = By.XPath("//*[@id='layout - main']/section[1]/div/div[1]/div/div/div[1]");
        private readonly By _goToAllNewsPage = By.XPath("//*[@id='posts-container']/div[1]/div/h1");

        public void ClickAllNewsPageButton() =>
            _webDriver.FindElement(_clickOnAllNewsButton).Click();

        public void ClickToSelectedNewsTitle() =>
            _webDriver.FindElement(_clickOnSelectedNewsTitle).Click();

        public void GoToSelectedNews() =>
            _webDriver.FindElement(_goToSelectedNews);
        
        public void GoToAllNewsPage() =>
            _webDriver.FindElement(_goToAllNewsPage); 
    }
}
