Feature: Accessing_App_NewUser_Feature
	As a new user 
	I want to have to register to log-in before I have access to the app,
	so that only authenticated users are capable of accessing the system.

@mytag
Scenario: New user creates an account
	Given I am on the Register page
	And I enter the relevent details
	When I click on Register
	Then I want to be granted access to the app and redirected to the Home page