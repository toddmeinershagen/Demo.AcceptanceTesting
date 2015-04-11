Feature: Logging In
	In order to use the application
	As a user
	I want to be able to login


Scenario: Valid Credentials
	Given valid username
	And valid password
	When I login
	Then the app should take me to the home page

Scenario: Invalid Credentials
	Given invalid username
	And invalid password
	When I login
	Then the app should take me to the login page
