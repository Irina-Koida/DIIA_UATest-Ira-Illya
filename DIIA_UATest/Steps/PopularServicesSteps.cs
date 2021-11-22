using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UATest.POM;

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

        [When(@"I click on the first service")]
        public void WhenIClickOnTheFirstService()
        {
            _popularServisesFromMainMenu.ClickToPopularServicePage();
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

        [Then(@"I navigate to the service page")]
        public void ThenINavigateToTheServicePage()
        {
            _popularServisesFromMainMenu.GoToToPopularServicePage();
        }

        [Then(@"Popular servises moved right on one position")]
        public void ThenPopularServisesMovedRightOnOnePosition()
        {
            _popularServisesFromMainMenu.MovedToTheRight();
        }

        [Then(@"Popular servises moved left on one position")]
        public void ThenPopularServisesMovedLeftOnOnePosition()
        {
            _popularServisesFromMainMenu.MovedToTheLeft();
        }

        [Then(@"Popular services moved one position\.")]
        public void ThenPopularServicesMovedOnePosition_()
        {
            _popularServisesFromMainMenu.MovedToTheRight();
        }

        [Then(@"Popular services moved one position to the left\.")]
        public void ThenPopularServicesMovedOnePositionToTheLeft_()
        {
            _popularServisesFromMainMenu.MovedToTheLeft();
        }
    }
}
