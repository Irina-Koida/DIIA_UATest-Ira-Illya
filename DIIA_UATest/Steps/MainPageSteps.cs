using TechTalk.SpecFlow;
using OpenQA.Selenium;
using DIIA_UATest.POM;

namespace DIIA_UATest.Steps
{
    [Binding]
    public sealed class MainPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly MainPage _mainPage;

        public MainPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            var webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _mainPage = new MainPage(webDriver);
        }

        [Given(@"Main page is open")]
        public void MainPageIsOpened()
        {
            _mainPage.GoToMainPage();
        }

        [Given(@"Cookie is closed")]
        public void CookieIsClosed()
        {
            _mainPage.CloseCookie();
        }
    }
}
