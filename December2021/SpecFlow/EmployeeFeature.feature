Feature: EmployeeFeature

	As a TurnUp portal admin
	I would like to create, edit and delete employee records
	So that I can manage my employees' records successfully.

@tag1
Scenario: [Create employee record with valid details]
	Given [I logged into TurnUp Portal successfully]
	And [I navigate to Employee page]
	When [I create Employee Record]
	Then [The record should be created Successfully]
