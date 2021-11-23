using TechTalk.SpecFlow;
using OpenQA.Selenium;
using DIIA_UATest.POM;

namespace DIIA_UATest.Steps
{

    [Binding]
    public sealed class GoToFaqPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly FAQblockFromMainPage _fAQblockFromMainPage;
        private readonly IWebDriver _webDriver;

        public GoToFaqPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            var webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _fAQblockFromMainPage = new FAQblockFromMainPage(webDriver);
        }

      

        [When(@"I moved to FAQ block")]
        public void WhenIMovedToFAQBlock()
        {
            _fAQblockFromMainPage.GoToMainPage();
        }

        [When(@"I click on FAQ button")]
        public void WhenIClickOnFAQButton()
        {
            _fAQblockFromMainPage.ClickOnQuestionAndAnswerButton();
        }

        [Then(@"I navigate to the FAQ Page")]
        public void ThenINavigateToTheFAQPage()
        {
            _fAQblockFromMainPage.WelcomeFaqPageText();
        }
    }
}