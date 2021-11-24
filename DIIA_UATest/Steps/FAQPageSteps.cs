using TechTalk.SpecFlow;
using OpenQA.Selenium;
using DIIA_UATest.POM;
using NUnit.Framework;

namespace DIIA_UATest.Steps
{
    [Binding]
    public class FAQPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly FAQblockFromMainPage _fAQblockFromMainPage;

        public FAQPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            var _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _fAQblockFromMainPage = new FAQblockFromMainPage(_webDriver);
        }

        [When(@"I click on the selected question ""(.*)""")]
        public void WhenIClickOnTheSelectedQuestion(string selectQuestion)
        {
            _fAQblockFromMainPage.ClickSelectQuestion(selectQuestion);
        }
        
        [Then(@"I navigated to the selected question ""(.*)""")]
        public void ThenINavigatedToTheSelectedQuestion(string selectQuestionPage)
        {
            string goToSelectedFAQ = _fAQblockFromMainPage.GoToSelectQuestionPage(selectQuestionPage);
            bool result = goToSelectedFAQ.Contains(selectQuestionPage);
            Assert.AreEqual(actual: result, expected: true);
        }

        [When(@"I moved to FAQ block")]
        public void WhenIMovedToFAQBlock()
        {
            _fAQblockFromMainPage.MovedFAQPage();
        }

        [When(@"I click on FAQ button")]
        public void WhenIClickOnFAQButton()
        {
            _fAQblockFromMainPage.ClickOnQuestionAndAnswerButton();
        }

        [Then(@"I navigate to the FAQ Page")]
        public void ThenINavigateToTheFAQPage()
        {
            string faqPage = _fAQblockFromMainPage.WelcomeFaqPageText();
            bool result = faqPage.Contains(faqPage);
            Assert.AreEqual(actual: result, expected: true);
        }
    }
}
