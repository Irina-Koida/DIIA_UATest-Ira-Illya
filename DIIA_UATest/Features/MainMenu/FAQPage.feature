Feature: FAQ Page
As a visitor of site 
I want to easily find the FAQ page 
In order to easily get answers to my questions

Background:
	Given Main page is open

@FAQ
Scenario: Go to FAQ page from Питання та відповіді Main Page block
	When I moved to 'Питання та відповіді' block
	When I click on 'Всі питання та відповіді' button
	Then I navigate to the FAQ Page
@FAQ
Scenario: Go to FAQ page from Питання та відповіді block by clicking arrow
	When I moved to 'Питання та відповіді' block
	When I click on 'Arrow' button from 'Питання та відповіді'block
	Then I navigate to the FAQ Page

