Feature: View_Role_Details_Feature
	As a user 
	I want to be able to access an individual page for each Role,
	so that I can see each Roles specific information.

@mytag
Scenario: User viewing a Role details
	Given I am on the Roles page
	When I click on a Role Detials
	Then I want to be redirected to a page with the Roles details and information