Feature: DatabaseFirstFeature

Feature about working with database first approach and making CRUD requests in the database

Scenario: 1 Adding record in the table
	When the user adds record to table
	Then the record has been added to table

Scenario: 2 Delete record from table
	Given the user adds record to table
	When the user deletes record from table
	Then the record has been deleted from table

Scenario: 3 Update record from table
	Given the user adds record to table
	When the user updates record
	Then the record is updated

Scenario: 4 Show records where BrandName = Nike
	Given the user has existing table brands
	When the user selects records where BrandName = Nike
	Then records with BrandName = 'Nike' are appeared

Scenario: 5 Select records with
	When when the user selects a record from the database by a certain attribute
	Then the user gets record with this attribute
