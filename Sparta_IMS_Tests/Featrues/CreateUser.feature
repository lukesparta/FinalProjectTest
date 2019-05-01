Feature: CreateUser
	In order to create a new user
	As another user
	I want to be able to create a new user

@mytag
Scenario: Create users
	Given create new user page
	And I complete all fields correctly
	When I click the submit button
	Then I should have added a new user in the system
