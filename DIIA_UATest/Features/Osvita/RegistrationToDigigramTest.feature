@Osvita
Feature:
Authorization form for Digigram testing 
As a potential student
I want  to enter my personal data
In order to be able to officially issue a certificate

Background:
	Given You are on the Osvita page

@Osvita @GoDigigigramTest
Scenario: Go to the start Digigigram testing
	When I Login
	When I click to Цифрограм buttom from header menu
	When I click to Розпочати тестування button
	When I choose a test to exam
	When I fill about info form
	Then I can start Digigram testing by clicking Перейти до тесту button