using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DIIA_UATest.POM
{
    class FAQblockFromMainPage
    {
        private readonly IWebDriver _webDriver;
        private readonly Actions _action;

        public FAQblockFromMainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _action = new Actions(_webDriver);
        }

        private readonly By _allQuestionAndAnswerButton = By.CssSelector(".wrap-all-link_link > span");
        private readonly By _faqPageHeaderMessage = By.CssSelector("[class=article-level-1]");
        private readonly By _movedFAQ = By.XPath("//*[@id='layout-main']/section[5]/div/div[1]/div[1]/h1");
        private readonly By _selectFAQ = By.XPath("//*[@id='layout-main']/section[5]/div/div[2]/div[2]/div/div[2]/a[1] ");
        private readonly By _goToSelectFAQ = By.XPath("//*[@id='layout-main']/section/div/div[1]/div/div/h1");

        public void ClickOnQuestionAndAnswerButton()
        {
            _webDriver.FindElement(_allQuestionAndAnswerButton).Click();
        }

        public string MovedFAQPage() =>
            _webDriver.FindElement(_movedFAQ).Text;

        public string WelcomeFaqPageText()
        {
            return _webDriver.FindElement(_faqPageHeaderMessage).Text;
        }

        public void ClickSelectQuestion(string selectQuestion) =>
         _action.MoveToElement(_webDriver.FindElement(_selectFAQ)).Click().Perform();

        public string GoToSelectQuestionPage(string selectQuestionPage)
        {
            return _webDriver.FindElement(_goToSelectFAQ).Text;
        }
    }
}
