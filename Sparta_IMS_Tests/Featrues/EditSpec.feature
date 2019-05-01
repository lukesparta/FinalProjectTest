Feature: Edit_Specialisation_Details_Feature
	As a user 
	I want to be able to edit existing Specialisation,
	So that I can update the Specialisation information when necessarry.

@mytag
Scenario: User edits Specialisation details
	Given I am on the Specialisation Details page 
	And I change some spec details 
	When click on Update
	Then I want to be redirected to the Specialisations page and any changes made are visibly updated
