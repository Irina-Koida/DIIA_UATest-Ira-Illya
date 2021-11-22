using OpenQA.Selenium;

namespace DIIA_UATest.POM
{
    class StoreToDownloadMobileApp
    {

        private readonly IWebDriver _webDriver;

        public StoreToDownloadMobileApp(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _clickApple = By.XPath("//*[@id='layout-footer']/div[2]/div/div/div[4]/div/a[1]");
        private readonly By _clickGoogle = By.XPath("//*[@id='layout-footer']/div[2]/div/div/div[4]/div/a[2]");
        private readonly By _clickHuawei = By.XPath("//*[@id='layout-footer']/div[2]/div/div/div[4]/div/a[3]");

        public void ClickOnAppleButton() =>
             _webDriver.FindElement(_clickApple).Click();

        public void ClickOnGoogleButton() =>
            _webDriver.FindElement(_clickGoogle).Click();

        public void ClickOnHuaweiButton() =>
            _webDriver.FindElement(_clickHuawei).Click();

        public StoreToDownloadMobileApp GoToApplePage()
        {
            _webDriver.Navigate().GoToUrl("https://apps.apple.com/us/app/%D0%B4%D1%96%D1%8F/id1489717872");
            return this;
        }

        public StoreToDownloadMobileApp GoToGooglePage()
        {
            _webDriver.Navigate().GoToUrl("https://play.google.com/store/apps/details?id=ua.gov.diia.app");
            return this;
        }

        public StoreToDownloadMobileApp GoToHuaweiPage()
        {
            _webDriver.Navigate().GoToUrl("https://appgallery.huawei.com/app/C102057503?appId=C102057503&source=appshare&subsource=C102057503");
            return this;
        }
    }
}
