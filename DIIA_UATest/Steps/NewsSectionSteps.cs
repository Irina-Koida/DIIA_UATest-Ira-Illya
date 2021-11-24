using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UATest.POM;
using NUnit.Framework;

namespace DIIA_UATest.Steps
{
    [Binding]
    public class NewsSectionSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly NewsSectionMainMenu _newsSectionMainMenu;
        private readonly IWebDriver _webDriver;

        public NewsSectionSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _newsSectionMainMenu = new NewsSectionMainMenu(_webDriver);
        }

        [When(@"I click on the all news button")]
        public void WhenIClickOnTheAllNewsButton()
        {
            _newsSectionMainMenu.ClickAllNewsPageButton();
        }

        [When(@"I click on the selected news ""(.*)""")]
        public void WhenIClickOnTheSelectedNews(string title)
        {
            _newsSectionMainMenu.ClickToSelectedNewsTitle(title);
        }

        [Then(@"I navigated to the news page ""(.*)""")]
        public void ThenINavigatedToTheNewsPage(string newsPage)
        {
            string goToNews = _newsSectionMainMenu.GoToAllNewsPage(newsPage);
            bool result = goToNews.Contains(newsPage);
           Assert.AreEqual( actual: result, expected: true);
        }

        [Then(@"I navigated to the selected news ""(.*)""")]
        public void ThenINavigatedToTheSelectedNews(string selectedNews)
        {
            string goToSelectedNews = _newsSectionMainMenu.GoToSelectedNews(selectedNews);
            bool result = goToSelectedNews.Contains(selectedNews);
            Assert.AreEqual(actual: result, expected: true);
        }
    }
}