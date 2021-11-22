Feature: StoreToDownloadApp
	As a visitor
	I want to be able to download the mobile application "Diia" from the main page
	In order to don't waste time looking for this mobile app myself

Background:
	Given Main page is open

@app
Scenario: Check the transition to the App Store by click the "Download on the App Store" button
	When I click the Download on the App Store button
	Then The App Store page to download the Diya app is open

@app
Scenario: Check the transition to the Google Play by click the "Get in on Google Play" button
	When I click Get in on Google Play button
	Then The Google Play page to download the Diya app is open

@app
Scenario: Check the transition to the HUAWEI Store by click the "Explore it on AppGallery" button
	When I click a Explore it on AppGallery button
	Then The HUAWEI AppGallery page to download the Diya app is open

