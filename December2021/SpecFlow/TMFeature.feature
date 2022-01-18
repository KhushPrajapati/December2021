Feature: TMFeature

	As a TurnUp portal admin
	I would like to create, edit and delete time and material records
	So that I can manage my employees' time and materials successfully.

@tag1
Scenario: [Create time and material record with valid details]
	Given [I logged into TurnUp Portal successfully]
	And [I navigate to Time and Material page]
	When [I create Time and Material Record]
	Then [The record should be created Successfully]

Scenario Outline: [Edit time and material record with valid details]
	Given [I logged into TurnUp Portal successfully]
	And [I navigate to Time and Material page]
	When [I update '<Description>' and '<Code>' an existing Time and Material Record]
	Then [The record should have an updated '<Description>' and '<Code>']

	Examples: 
	| Description | Code         |
	| Time        | Code         |
	| Material    | Edited Code  |
	

Scenario: [Delete time and material record]
	Given [I logged into TurnUp Portal successfully]
	And [I navigate to Time and Material page]
	When [I delete existing Time and Material record]
	Then [The record should have deleted]
