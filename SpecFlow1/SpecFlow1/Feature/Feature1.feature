Feature: Feature1

The user clicks on search button
Summer is displayed in line Search above list of products

Scenario: 1 Summer is displayed on the products page 
	Given the user enters 'Summer' in search-field on the base page
	When the user clicks on search button 
	Then Summer is displayed in line Search above list of products on the base page

Scenario: sorting is performed from high to low price when the user choices option Price: Highest first then
	Given the user enters 'Summer' in search-field on the base page
	And the user clicks on search button 
	When the user choices option Price: Highest first on products page
	Then sorting is performed from high price to low on products page

Scenario: the price in column 'Total' corresponds to price of item when the user adds item to cart
	Given the user enters 'Summer' in search-field on the base page
	And the user clicks on search button 
	And the user choices option Price: Highest first on products page
	And the user adds item to cart on products page
	And the user clicks 'Continue shopping' in popup
	When the user clicks on the cart button 
	Then the price in column 'Total' corresponds to price of item
	And the name in column 'Description' corresponds to price of item

Scenario: 4message 'Product successfully added to your shopping cart' is appeared when the user adds item to cart
	Given the user enters 'Blouse' in search-field on the base page
	And the user clicks on search button 
	And the user preses 'More' button for the first item on products page
	And the user sets parametres for item on TShirts page
		| Quantity | Size | Color |
		| 3        | L    | white |
	When the user clicks on add to cart button on TShirts page
	Then the message 'Product successfully added to your shopping cart' is appeared

	Scenario: 5items are displayed with right parametres when the user adds two items to cart
	Given the user enters 'Blouse' in search-field on the base page
	And the user clicks on search button 
	And the user preses 'More' button for the first item on products page
	And the user sets parametres for item on TShirts page
		| Quantity |Size |   Color |
		| 3        |  L  | white   |
	And the user clicks on add to cart button
	And the user clicks 'Continue shopping' in popup
	And the user deletes 'Blouse' from search-field
	And the user enters 'Printed summer' in search-field on the base page
	And the user clicks on search button 
	And the user preses 'More' button for the first item on products page
	And the user sets parametres for item (adds quantity,color,size) on TShirts page
		| Quantity |  | Size |  | Color  |
		| 5        |  | M    |  | orange |
	And the user clicks on add to cart button
	When the user clicks 'Proceed to checkout' button
	Then blouse is displayed with right parameters
	And dress is displayed with right parameters

	Scenario: blouse remains in cart when the user deletes one dress from cart
	Given the user enters 'Blouse' in search-field on the base page
	And the user clicks on search button 
	And the user preses 'More' button for the first item on products page
	And the user sets parametres for item on TShirts page
		| Quantity |  | Size |  | Color |
		| 3        |  | L    |  | white |
	And the user clicks on add to cart button
	And the user clicks 'Continue shopping' in popup
	And the user deletes 'Blouse' from search-field
	And the user enters 'Printed summer dress' in search-field on the base page
	And the user clicks on search button 
	And the user preses 'More' button for the first item on products page
	And the user sets parametres for item (adds quantity,color,size) on TShirts page
		| Quantity |  | Size |  | Color  |
		| 5        |  | M    |  | orange |
	And the user clicks on add to cart button
	And the user clicks 'Proceed to checkout' button
	And the user clicks on the delete button
	When dress is not remains on the page
	Then only a blouse remains in the table

	Scenario: 7
	Given the user enters 'T-shirt' in search-field on the base page
	And the user clicks on search button
	And the user preses 'More' button for the first item on products page
	And the user clicks on Send to a friend button
	And the user feels Name of friend field
	And the user feels E-mail field
	When the user clicks Send button
	Then appears success message Your e-mail has been sent successfully














	      

