Feature: Edit_SpartanUser_Details_Feature
	As a user 
	I want to be able to edit a SpartanUser,
	So that I can update the SpartanUser's information when necessarry.

@mytag
Scenario: User edits Spartan Users details
	Given I am on the edit SpartanUser page 
	And I change some details
	When I click on Update
	Then I want to be redirected to the Sparta Users page and any changes made are visibly updated
