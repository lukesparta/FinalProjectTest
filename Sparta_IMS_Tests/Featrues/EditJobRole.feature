Feature: Edit_Role_Details_Feature
	As a user 
	I want to be able to edit existing Role,
	So that I can update the Role information when necessarry.

@mytag
Scenario: User edits Role details
	Given I am on the Role Details page 
	And I change some edit details 
	When I click on edit Update
	Then I want to be redirected to the Roles page and any changes made are visibly updated