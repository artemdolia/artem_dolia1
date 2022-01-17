Feature: Dummy Test


API testing of basic methods on the resource http://dummy.restapiexample.com/api/v1


Scenario: 1 Get all employees
	When the user sends GET request for all employees
	Then appeared response with successful status

Scenario: 2 Get employee by id
	When the user sends GET request for single employee by id
	Then appeared response with successful status

Scenario: 3 Create employee
	When the user sends Post request for single employee
	Then appeared response with successful status
	And id in data is not null

Scenario: 4 Delete employee
	When the user sends DELETE request
	Then appeared response with successful message
	And appeared DELETE response with successful status

Scenario: 5 Update name of employee
	When the user sends PUT request
	Then appeared response with successful status 200
	And the employee_name has been changed

Scenario: 6 Delete not exist employee
	When the user sends Delete request with non exist id
	Then appeared response with empty data
