Feature: PopularServices
	As a visitor
    I want to see a popular servises on the main page
	In order to find them faster

Background:
	Given Main page is open

@popularservice @swiper
Scenario: Check navigation to the service page from the block with popular service
	When I click on the first service
	Then I navigate to the service page

@swiper @popularservice
Scenario: Check the swipe right the popular services by swiper - right button
	When I click on the swiper rigt button
	Then Popular servises moved right on one position

@swiper @popularservice
Scenario: Check the swipe left the popular services by swiper - left button
	When I click on the swiper rigt button
	Then Popular servises moved right on one position
	When I click on the swiper left button
	Then Popular servises moved left on one position

@swiper @popularservice
Scenario: Check the swipe to the left of popular services bullet pagination
	When I click on the right side of the pagination bullet bar
	Then Popular services moved one position.
	When I click from left to right on the pagination bullet bar
	Then Popular services moved one position to the left.

@swiper @popularservice
Scenario: Check the swipe to the right of popular services bullet pagination
	When I click on the right side of the pagination bullet bar
	Then Popular services moved one position.