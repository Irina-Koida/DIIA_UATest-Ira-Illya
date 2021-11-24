Feature: NewsSection
	As a visitor
    I want to see the news section on the main page
	In order to read the hot news 

Background:
	Given Main page is open
	Given Cookie is closed

@newssection
Scenario: Check navigation to the news page from the block with news
	When I click on the all news button
	Then I navigated to the news page "Новини"

@newssection
Scenario: Check navigation to the select news page from the block with news
	When I click on the selected news "COVID-сертифікат у Дії стане отримати простіше: що змінилося"
	Then I navigated to the selected news "COVID-сертифікат у Дії стане отримати простіше: що змінилося"
