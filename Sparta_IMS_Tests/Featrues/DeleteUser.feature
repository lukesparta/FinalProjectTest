Feature: Delete_SpartanUser_Feature
	As a user 
	I want to be able to delete a SpartaUser,
	So that I can remove a SpartanUser from the system when necessarry.

@mytag
Scenario: User deletes Spartan User from the system
	Given I am on a SpartanUser Details page
	When I click on Delete
	Then I want to be redirected to the Sparta Users page and that SpartanUser should be deleted from the SpartanUsers table