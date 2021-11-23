Feature: FAQ Page
As a visitor of site 
I want to easily find the FAQ page 
In order to easily get answers to my questions


@FAQ
Scenario: Go to FAQ page from MainPage 
	When I moved to FAQ block
	When I click on FAQ button
	Then I navigate to the FAQ Page
#@FAQ
#Scenario: Go to FAQ page from MainPage by clicking arrow
#	When I moved to FAQ block
#	When I click on Arrow button from FAQ block
#	Then I navigate to the FAQ Page