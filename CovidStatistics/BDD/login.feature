Feature: Login Page
	As A registered user of the Covid Statistics website
	I want to be able to sign in
	So that I can access my account

@navigate
Scenario: Go to Login page from home page
	Given I am on the home page
	When I click the login link
	Then I go to login page