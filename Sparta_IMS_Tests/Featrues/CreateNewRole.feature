Feature: Create_New_Role_Feature
	As a user 
	I want to be able to create a new Role,
	so that I can add new Role to the system.

@mytag
Scenario: User creating a new Role
	Given I am on the Create Roles page
	And I enter the Role name
	When I press on Create button
	Then I want to be redirected to the Roles page and the new Specialisation to be added to the Roles table