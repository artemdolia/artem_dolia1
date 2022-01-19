Feature: Dummy Test


API testing of basic methods on the resource http://dummy.restapiexample.com/api/v1


Scenario: 1 Get all employees
	When the user sends GET request for all employees
	Then appeared response with 'success' status

Scenario: 2 Get employee by id
	When the user sends GET request for single employee by id
	Then appeared response with 'success' status

Scenario: 3 Create employee
	When the user sends Post request for single employee
	Then appeared response with 'success' status
	And id in data is not null

Scenario: 4 Delete employee
	When the user sends DELETE request
	Then appeared response with 'Successfully! Record has been deleted'
	And appeared response with 'success' status

Scenario: 5 Update name of employee
	When the user sends PUT request
	Then appeared response with 'success' status
	And the employee_name has been changed

Scenario: 6 Get not exist employee
	When the user sends Get request with non exist id
	Then appeared response with empty data
