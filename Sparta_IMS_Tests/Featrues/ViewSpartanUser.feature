Feature: View_SpartanUser_Details_Feature
	As a user 
	I want to be able to access an individual page for each SpartaUser,
	so that I can see each SpartaUsers specific information.

@mytag
Scenario: User viewing a Spartan Users details
	Given I am on the Sparta Users page
	When I click on a SpartanUser
	Then I want to be redirected to a page with the SpartanUsers details and information
