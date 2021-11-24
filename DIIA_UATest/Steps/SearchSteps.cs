using OpenQA.Selenium;
using DIIA_UATest.POM;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;

namespace DIIA_UATest.Steps
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly SearchFromMainMenu _searchFromMainMenu;
        private readonly IWebDriver _webDriver;

        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _searchFromMainMenu = new SearchFromMainMenu(_webDriver);
        }

        [When(@"I input ""(.*)"" in the search field")]
        public void WhenIInputInTheSearchField(string input)
        {
            _searchFromMainMenu.InputOnSearchInformationField(input);
        }

        [When(@"I click a search button")]
        public void WhenIClickASearchButton()
        {
            _searchFromMainMenu.ClickOnSearchInformationField();
        }

        [Then(@"I see a open  search page with text ""(.*)""")]
        public void ThenISeeAOpenSearchPageWithText(string request)
        {
            Thread.Sleep(300);
            string requestInfo = _searchFromMainMenu.SearchInfoRequestText();
            bool resultatRequest = requestInfo.Contains(request);

            Assert.AreEqual(actual: resultatRequest, expected: true);
        }

        [Then(@"I see a open  search page with text invalid ""(.*)""")]
        public void ThenISeeAOpenSearchPageWithTextInvalid(string requestInvalid)
        {
            Thread.Sleep(300);
            string requestInfoInvalid = _searchFromMainMenu.SearchInfoRequestText(requestInvalid);
            bool resultatRequestInvalid = requestInfoInvalid.Contains(requestInvalid);

            Assert.AreEqual(actual: resultatRequestInvalid, expected: false);
        }
    }
}