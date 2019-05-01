Feature: View_Specialisation_Details_Feature
	As a user 
	I want to be able to access an individual page for each Specialisation,
	so that I can see each Specialisation specific information.

@mytag
Scenario: User viewing a Specialisation details
	Given I am on the Specialisation page
	When I click on a Specialisation details
	Then I want to be redirected to a page with the Specialisations details and information