Feature: Search
	As a visitor
    I want to search information on the main page
	In order to quickly find the information I need

Background:
	Given Main page is open

@valid
Scenario: Check the search result witn valid input
	When I input "ФОП" in the search field
	When I click a search button
	Then I see a open  search page with text "За вашим запитом знайдено матеріалів:"

@invalid
Scenario: Check the search results page for the content of the message if invalid values are entered
	When I input "FOP" in the search field
	When I click a search button
	Then I see a open  search page with text "За вашим запитом не знайдено матеріалів"