Feature: Pressing Keys
	In order to trigger an action
	As a user
	I want to be able to press certain key combinations

Scenario: Ctrl+Space
	Given I enter the keypress page
	When I press both control and space together
	Then the message should be 'true'

Scenario: Ctrl+C
	Given I enter the keypress page
	When I press both control and c together
	Then the message should be 'false'
