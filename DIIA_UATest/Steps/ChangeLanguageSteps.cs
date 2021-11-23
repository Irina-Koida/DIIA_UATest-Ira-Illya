using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UATest.POM;

namespace DIIA_UATest.Steps
{
    [Binding]
    public sealed class ChangeLanguageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly OsvitaPage _osvitaPage;
        private readonly IWebDriver _webDriver;

        public ChangeLanguageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _osvitaPage = new OsvitaPage(_webDriver);
        }

        [Given(@"You are on Osvita page")]
        public void GivenYouAreOnOsvitaPage()
        {
            _osvitaPage.GoToOsvitaPage();
        }

        [When(@"I click to language swicher button from header")]
        public void WhenIClickToLanguageSwicherButtonFromHeader()
        {
            _osvitaPage.SwichLanguage();
        }

        [When(@"I see the page refresh")]
        public void WhenISeeThePageRefresh()
        {

        }

        [Then(@"The text on Osvita page has changed to the selected")]
        public void ThenTheTextOnOsvitaPageHasChangedToTheSelected()
        {
           _webDriver.Navigate().GoToUrl("https://osvita.diia.gov.ua/en");
        }
    }
}