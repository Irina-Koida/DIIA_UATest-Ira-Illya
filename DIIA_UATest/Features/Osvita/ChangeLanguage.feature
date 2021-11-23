Feature:  Change language
	As a visitor of site
	I want to manage Osvita Page language 
	In order to make page information more understable to me

Background:
	Given You are on Osvita page

@Osvita
Scenario: Change Osvita page language
	When I click to language swicher button from header
	When I see the page refresh
	Then The text on Osvita page has change