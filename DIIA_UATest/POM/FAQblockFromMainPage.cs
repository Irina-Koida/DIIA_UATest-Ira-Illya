using OpenQA.Selenium;

namespace DIIA_UATest.POM
{
    class FAQblockFromMainPage
    {

        private readonly IWebDriver _webDriver;
        public FAQblockFromMainPage(IWebDriver webDriver)

        {
            _webDriver = webDriver;
        }

        public By _allQuestionAndAnswerButton = By.CssSelector(".wrap-all-link_link > span");
        public By _faqPageHeaderMessage = By.CssSelector("[class=article-level-1]");

        public FAQblockFromMainPage GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;

        }
        public void ClickOnQuestionAndAnswerButton()
        {
            _webDriver.FindElement(_allQuestionAndAnswerButton).Click();
        }

        public void WelcomeFaqPageText()
        {
            _webDriver.FindElement(_faqPageHeaderMessage);
        }
    }
}
