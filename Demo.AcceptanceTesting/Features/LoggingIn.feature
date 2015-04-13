Feature: Logging In
	In order to use the application
	As a user
	I want to be able to login


Scenario: Valid Credentials
	Given valid username
	And valid password
	When I login
	Then the app should take me to the home page

Scenario Outline: Invalid Credentials
	Given invalid username of '<username>'
	And invalid password of '<password>'
	When I login
	Then the app should take me to the login page

	Examples:
	| username               | password   |
	| tammy@meinershagen.net | unpassword |
	| ellie@meinershagen.net | unpassword |
	| chloe@meinershagen.net | unpassword |