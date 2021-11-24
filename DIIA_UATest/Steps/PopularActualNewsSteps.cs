using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UATest.POM;
using NUnit.Framework;

namespace DIIA_UATest.Steps
{
    [Binding]
    public class PopularActualNewsSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly PopularActualNews _popularActualNews;
        private readonly IWebDriver _webDriver;

        public PopularActualNewsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _popularActualNews = new PopularActualNews(_webDriver);
        }

        [Given(@"News page is open")]
        public void GivenNewsPageIsOpen()
        {
            _popularActualNews.GoToNewsPage();
        }

        [When(@"I click more news button")]
        public void WhenIClickMoreNewsButton()
        {
            _popularActualNews.СlickMoreNewsButton();
        }

        [When(@"I click next page button")]
        public void WhenIClickNextPageButton()
        {
            _popularActualNews.СlikNextPageButton();
        }

        [When(@"I click previous page button")]
        public void WhenIClickPreviousPageButton()
        {
            _popularActualNews.ClikPreviousPageButton();
        }

        [When(@"I click on the ""(.*)""")]
        public void WhenIClickOnThe(string firstNews)
        {
            _popularActualNews.ClickToSelectedNews(firstNews);
        }

        [Then(@"The pagination number of next page are active")]
        public void ThenThePaginationNumberOfNextPageAreActive()
        {
           string redirectNextPage = _popularActualNews.SeeAActivePlaginationNextPage();
           bool result = redirectNextPage.Contains(redirectNextPage);
           //Assert.AreEqual(true, redirectNextPage);
           Assert.AreEqual(actual: result, expected: true);
        }

        [Then(@"I navigate to the next page")]
        public void ThenINavigateToTheNextPage()
        {
           string redirectNext = _popularActualNews.SeeAActivePlaginationNextPage();
           bool result = redirectNext.Contains(redirectNext);
           Assert.AreEqual(actual: result, expected: true);
        }

        [Then(@"I navigate to the previous page")]
        public void ThenINavigateToThePreviousPage()
        {
            string redirectPrevious = _popularActualNews.SeeAActivePlaginationPreviousPage();
            bool result = redirectPrevious.Contains(redirectPrevious);
            Assert.AreEqual(actual: result, expected: true);
        }

        [Then(@"I navigate to the ""(.*)""")]
        public void ThenINavigateToThe(string selectedNewsPage)
        {
            Assert.AreEqual(actual: _popularActualNews.GoToSelectedNewsPage(selectedNewsPage) , expected: selectedNewsPage);
        }
    }
}