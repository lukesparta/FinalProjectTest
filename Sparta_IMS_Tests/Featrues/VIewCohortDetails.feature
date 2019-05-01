Feature: View_Cohort_Details_Feature
	As a user 
	I want to be able to access an individual page for each Cohort,
	so that I can see each Cohort specific information.

@mytag
Scenario: User viewing a Cohorts details
	Given I am on the Cohort page
	When I click on a Cohort
	Then I want to be redirected to a page with the Cohorts details and information