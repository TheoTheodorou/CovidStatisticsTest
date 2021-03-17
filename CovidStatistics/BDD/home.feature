Feature: home
As a logged in user 
I want to be able to see the records link
so that I can check the status of the world

@not logged in
Scenario: Not logged in
	Given that I am on home page
	Then I cannot see the records link