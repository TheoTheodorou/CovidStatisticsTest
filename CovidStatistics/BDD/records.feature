Feature: Records
	As a user
	I want to be able to add records
	So that I can track covid rates

@records
Scenario: Direct url link - does not show records
	Given I am on the homepage
	And I am not logged in
	When I enter the records url directly
	Then I should not see the records table

@records
Scenario: Adding records to table - records shows up
	Given I am on the create records page
	When I add a record
	Then I should see the record in the table