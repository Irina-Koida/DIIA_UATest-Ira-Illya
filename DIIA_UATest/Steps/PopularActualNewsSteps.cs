﻿using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UATest.POM;
using NUnit.Framework;

namespace DIIA_UATest.Steps
{
    [Binding]
    public class PopularActualNewsSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly PopularActualNews _popularActualNews;
        private readonly IWebDriver _webDriver;

        public PopularActualNewsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _popularActualNews = new PopularActualNews(_webDriver);
        }

        [Given(@"News page is open")]
        public void GivenNewsPageIsOpen()
        {
            _popularActualNews.GoToNewsPage();
        }

        [When(@"I click more news button")]
        public void WhenIClickMoreNewsButton()
        {
            _popularActualNews.СlickMoreNewsButton();
        }

        [When(@"I click next page button")]
        public void WhenIClickNextPageButton()
        {
            _popularActualNews.СlikNextPageButton();
        }

        [When(@"I click previous page button")]
        public void WhenIClickPreviousPageButton()
        {
            _popularActualNews.ClikPreviousPageButton();
        }

        [When(@"I click on the first news")]
        public void WhenIClickOnTheFirstNews()
        {
            _popularActualNews.ClickToSelectedNews();
        }

        [Then(@"The pagination number of next page are active")]
        public void ThenThePaginationNumberOfNextPageAreActive()
        {
            _popularActualNews.SeeAActivePlaginationNextPage();
        }

        [Then(@"I navigate to the next page")]
        public void ThenINavigateToTheNextPage()
        {
           Assert.IsTrue(_popularActualNews.SeeAActivePlaginationNextPage());
        }

        [Then(@"I navigate to the previous page")]
        public void ThenINavigateToThePreviousPage()
        {
           Assert.IsTrue(_popularActualNews.SeeAActivePlaginationPreviousPage());
        }

        [Then(@"I navigate to the news page")]
        public void ThenINavigateToTheNewsPage()
        {
            Assert.AreEqual("Мстислав Банік на Західній Україні: «Вражає швидкість," +
                " з якою на місцях підтримали ініціативу створення офлайн-пунктів Команди підтримки Дії»",
                _popularActualNews.GoToSelectedNewsPage());
        }
    }
}