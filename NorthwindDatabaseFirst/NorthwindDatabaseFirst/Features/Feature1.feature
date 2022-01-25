Feature: Feature1

Feature about CRUD with database Northwind

Scenario: 1 Adding record in the table
	When the user adds record to table 
	| BrandName | "Nike" |
	Then the record 'Nike' has been added to table

Scenario: 2 Delete record from table
    When the user deletes record from table 'Brands'
	Then the record has been deleted from table

