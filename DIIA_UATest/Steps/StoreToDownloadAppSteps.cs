using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UATest.POM;

namespace DIIA_UATest.Steps
{
    [Binding]
    public class StoreToDownloadAppSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly StoreToDownloadMobileApp _storeToDownloadMobileApp;
        private readonly IWebDriver _webDriver;

        public StoreToDownloadAppSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _storeToDownloadMobileApp = new StoreToDownloadMobileApp(_webDriver);
        }

        [When(@"I click the Download on the App Store button")]
        public void WhenIClickTheDownloadOnTheAppStoreButton()
        {
            _storeToDownloadMobileApp.ClickOnAppleButton();
        }

        [When(@"I click Get in on Google Play button")]
        public void WhenIClickGetInOnGooglePlayButton()
        {
            _storeToDownloadMobileApp.ClickOnGoogleButton();
        }

        [When(@"I click a Explore it on AppGallery button")]
        public void WhenIClickAExploreItOnAppGalleryButton()
        {
            _storeToDownloadMobileApp.ClickOnHuaweiButton();
        }

        [Then(@"The App Store page to download the Diya app is open")]
        public void ThenTheAppStorePageToDownloadTheDiyaAppIsOpen()
        {
            _storeToDownloadMobileApp.GoToApplePage();
        }

        [Then(@"The Google Play page to download the Diya app is open")]
        public void ThenTheGooglePlayPageToDownloadTheDiyaAppIsOpen()
        {
            _storeToDownloadMobileApp.GoToGooglePage();
        }

        [Then(@"The HUAWEI AppGallery page to download the Diya app is open")]
        public void ThenTheHUAWEIAppGalleryPageToDownloadTheDiyaAppIsOpen()
        {
            _storeToDownloadMobileApp.GoToHuaweiPage();
        }
    }
}
