Feature: PopularActualNews
As a user
I want see a news on the news page
In order to read the news

Background:
	Given News page is open

@news
Scenario: Check that pagination number of next page become active when you click the "More news" button
	When I click more news button
	Then The pagination number of next page are active

@news
Scenario: Check the navigation to the next page by click the "Next page" button
	When I click next page button
	Then I navigate to the next page

@news
Scenario: Check the navigation to the previous page by click the "Previous page" button
    When I click next page button
	Then I navigate to the next page
	When I click previous page button
	Then I navigate to the previous page

@news
Scenario: Check navigation to the news page from the block with news
	When I click on the first news
	Then I navigate to the news page