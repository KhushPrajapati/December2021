Feature: EmployeeFeature

	As a TurnUp portal admin
	I would like to create, edit and delete employee records
	So that I can manage my employees' records successfully.

@tag1
Scenario: 1 [Create employee record with valid details]
	Given [I logged in to TurnUp Portal successfully]
	And [I navigate to Employee page]
	When [I create Employee Record]
	Then [The Employee record should be created Successfully]

Scenario Outline: 2 [Edit employee record with valid details]
	Given [I logged into TurnUp Portal successfully]
	And [I navigate to Employee page]
	When [I update '<UserName>'an existing employee record]
	Then [The Employee record should have an updated '<UserName>']

	Examples: 
	| UserName |
	| Dec123   |
	| Dec321   |
	| Dec 345  |

Scenario: 3 [Delete employee record]
	Given [I logged into TurnUp Portal successfully]
	And [I navigate to Employee page]
	When [I delete an existing employee record]
	Then [The Employee record should have deleted]

