using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UATest.POM;

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
        
        [When(@"I click on the selected news title")]
        public void WhenIClickOnTheSelectedNewsTitle()
        {
            _newsSectionMainMenu.ClickToSelectedNewsTitle();
        }
        
        [Then(@"I navigated to the news page")]
        public void ThenINavigatedToTheNewsPage()
        {
            _newsSectionMainMenu.GoToAllNewsPage();
        }
        
        [Then(@"I navigated to the selected news page")]
        public void ThenINavigatedToTheSelectedNewsPage()
        {
            _newsSectionMainMenu.GoToSelectedNews();
        }
    }
}
