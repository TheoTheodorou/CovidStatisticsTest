Feature: register
As a user I want to be able to register a new account

@mytag
Scenario: Register new account
	Given I am on the register page
	And I enter the email "test1@test.com"
	And I enter the password "Test!123"
	When I click the register button
	Then I should be taken to the confirm email page