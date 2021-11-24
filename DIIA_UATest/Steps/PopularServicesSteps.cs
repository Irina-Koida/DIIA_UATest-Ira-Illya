using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UATest.POM;
using NUnit.Framework;

namespace DIIA_UATest.Steps
{
    [Binding]
    public class PopularServicesSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly PopularServisesFromMainMenu _popularServisesFromMainMenu;
        private readonly IWebDriver _webDriver;

        public PopularServicesSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _popularServisesFromMainMenu = new PopularServisesFromMainMenu(_webDriver);
        }

        [When(@"I click on the first ""(.*)""")]
        public void WhenIClickOnTheFirst(string servises)
        {
            _popularServisesFromMainMenu.ClickToPopularServicePage(servises);
        }

        [When(@"I click on the swiper rigt button")]
        public void WhenIClickOnTheSwiperRigtButton()
        {
            _popularServisesFromMainMenu.ClickToTheRightSide();
        }

        [When(@"I click on the swiper left button")]
        public void WhenIClickOnTheSwiperLeftButton()
        {
            _popularServisesFromMainMenu.ClickToTheLeftSide();
        }

        [When(@"I click on the right side of the pagination bullet bar")]
        public void WhenIClickOnTheRightSideOfThePaginationBulletBar()
        {
            _popularServisesFromMainMenu.SwipeToTheRightClick();
        }

        [When(@"I click from left to right on the pagination bullet bar")]
        public void WhenIClickFromLeftToRightOnThePaginationBulletBar()
        {
            _popularServisesFromMainMenu.SwipeToTheLeftClick();
        }

        [Then(@"I navigate to the service ""(.*)""")]
        public void ThenINavigateToTheService(string servisePage)
        {
            string navigate = _popularServisesFromMainMenu.GoToToPopularServicePage();
            bool request = navigate.Contains(servisePage);

            Assert.AreEqual(actual: request, expected: true);
        }

        [Then(@"Popular servises moved right on one position")]
        public void ThenPopularServisesMovedRightOnOnePosition()
        {
            Assert.IsTrue(!_popularServisesFromMainMenu.MovedToTheRight());
        }

        [Then(@"Popular servises moved left on one position")]
        public void ThenPopularServisesMovedLeftOnOnePosition()
        {
            string redirectLeft = _popularServisesFromMainMenu.MovedToTheLeft();
            bool result = redirectLeft.Contains(redirectLeft);
            Assert.AreEqual(actual: result, expected: true);
        }

        [Then(@"Popular services moved one position\.")]
        public void ThenPopularServicesMovedOnePosition_()
        {
           Assert.IsTrue(!_popularServisesFromMainMenu.MovedToTheRight());
        }

        [Then(@"Popular services moved one position to the left\.")]
        public void ThenPopularServicesMovedOnePositionToTheLeft_()
        {
            string redirectLeft = _popularServisesFromMainMenu.MovedToTheLeft();
            bool result = redirectLeft.Contains(redirectLeft);
            Assert.AreEqual(actual: result, expected: true);
        }
    }
}