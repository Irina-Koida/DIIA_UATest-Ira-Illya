Feature: FAQ Page
As a visitor of site 
I want to easily find the FAQ page 
In order to easily get answers to my questions

Background:
	Given Main page is open
	Given Cookie is closed

@FAQ
Scenario: Go to FAQ page from MainPage 
	When I moved to FAQ block
	When I click on FAQ button
	Then I navigate to the FAQ Page
@FAQ
Scenario: Check navigation to the select FAQ page from the FAQ block 
	When I click on the selected question "Повернення коштів після сплати за виконавчими провадженнями"
	Then I navigated to the selected question "Повернення коштів після сплати за виконавчими провадженнями"

