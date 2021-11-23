using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UATest.POM;
using NUnit.Framework;

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
          Assert.AreEqual("https://apps.apple.com/us/app/%D0%B4%D1%96%D1%8F/id1489717872",
              _storeToDownloadMobileApp.GoToApplePage());
        }

        [Then(@"The Google Play page to download the Diya app is open")]
        public void ThenTheGooglePlayPageToDownloadTheDiyaAppIsOpen()
        {
           Assert.AreEqual("https://play.google.com/store/apps/details?id=ua.gov.diia.app", 
               _storeToDownloadMobileApp.GoToGooglePage());
        }

        [Then(@"The HUAWEI AppGallery page to download the Diya app is open")]
        public void ThenTheHUAWEIAppGalleryPageToDownloadTheDiyaAppIsOpen()
        {
          Assert.AreEqual("https://appgallery.huawei.com/app/C102057503?appId=C102057503&source=appshare&subsource=C102057503", 
              _storeToDownloadMobileApp.GoToHuaweiPage());
        }
    }
}
