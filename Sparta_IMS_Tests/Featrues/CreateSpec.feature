Feature: Create_New_Specialisation_Feature
	As a user 
	I want to be able to create a new Specialisation,
	so that I can add new Specialisation to the system.

@mytag
Scenario: User creating a new Specialisation
	Given I am on the Create Specialisation page
	And I enter the Specialisation name
	When I click on Create button
	Then I want to be redirected to the Specialisations page and the new Specialisation to be added to the Specialisations table