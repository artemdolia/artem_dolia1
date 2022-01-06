Feature: Main functionality of the products site

The user can search, change and add to a cart items.

@Browser:Chrome
@Browser:Edge
Scenario Outline: 1) Summer is displayed on the products page
	Given the site is opened in the '<Browser>'
	And the user enters 'Summer' in search-field on the base page
	When the user clicks on the search button
	Then Summer is displayed in line Search above list of products on the base page
Examples:
	| Browser |
	| Chrome  |
	| Edge    |

@Browser:Chrome
@Browser:Edge
Scenario Outline: 2) sorting is performed from high to low price when the user choices option Price: Highest first then
	Given the site is opened in the '<Browser>'
	And the user enters 'Summer' in search-field on the base page
	And the user clicks on the search button
	When the user choices option Price: Highest first on the products page
	Then sorting is performed from high price to low on the products page
Examples:
	| Browser |
	| Chrome  |
	| Edge    |

@Browser:Chrome
@Browser:Edge
Scenario Outline: 3) the price in column 'Total' corresponds to price of item when the user adds item to cart
	Given the site is opened in the '<Browser>'
	And the user enters 'Summer' in search-field on the base page
	And the user clicks on the search button
	And the user choices option Price: Highest first on products page
	And the user adds item to cart on products page
	And the user clicks 'Continue shopping' in the popup
	When the user clicks on the cart button
	Then the price in column 'Total' corresponds to price of item
	And the name in column 'Description' corresponds to price of item
Examples:
	| Browser |
	| Chrome  |
	| Edge    |

@Browser:Chrome
@Browser:Edge
Scenario Outline: 4) message 'Product successfully added to your shopping cart' is appeared when the user adds item to cart
	Given the site is opened in the '<Browser>'
	And the user enters 'Blouse' in search-field on the base page
	And the user clicks on the search button
	And the user presses 'More' button for the first item on the products page
	And the user sets parameters for item on TShirts page
		| Quantity | Size | Color |
		| 3        | L    | white |
	When the user clicks on add to cart button on TShirts page
	Then the message 'Product successfully added to your shopping cart' is appeared
Examples:
	| Browser |
	| Chrome  |
	| Edge    |

@Browser:Chrome
@Browser:Edge
Scenario Outline: 5) items are displayed with right parametres when the user adds two items to cart
	Given the site is opened in the '<Browser>'
	And the user enters 'Blouse' in search-field on the base page
	And the user clicks on the search button
	And the user presses 'More' button for the first item on the products page
	And the user sets parameters for item on TShirts page
		| Quantity | Size | Color |
		| 3        | L    | white |
	And the user clicks on add to cart button
	And the user clicks 'Continue shopping' in the popup
	And the user deletes 'Blouse' from search-field
	And the user enters 'Printed summer' in search-field on the base page
	And the user clicks on the search button
	And the user presses 'More' button for the first item on the products page
	And the user sets parameters for item (adds quantity,color,size) on TShirts page
		| Quantity |  | Size |  | Color  |
		| 5        |  | M    |  | orange |
	And the user clicks on add to cart button
	When the user clicks 'Proceed to checkout' button
	Then blouse is displayed with the right parameters
	And dress is displayed with right parameters
Examples:
	| Browser |
	| Chrome  |
	| Edge    |

@Browser:Chrome
@Browser:Edge
Scenario Outline: 6) blouse remains in cart when the user deletes one dress from cart
	Given the site is opened in the '<Browser>'
	And the user enters 'Blouse' in search-field on the base page
	And the user clicks on the search button
	And the user presses 'More' button for the first item on the products page
	And the user sets parameters for item on TShirts page
		| Quantity |  | Size |  | Color |
		| 3        |  | L    |  | white |
	And the user clicks on add to cart button
	And the user clicks 'Continue shopping' in the popup
	And the user deletes 'Blouse' from search-field
	And the user enters 'Printed summer dress' in search-field on the base page
	And the user clicks on the search button
	And the user presses 'More' button for the first item on the products page
	And the user sets parameters for item (adds quantity,color,size) on TShirts page
		| Quantity |  | Size |  | Color  |
		| 5        |  | M    |  | orange |
	And the user clicks on add to cart button
	And the user clicks 'Proceed to checkout' button
	And the user clicks on the delete button
	When the dress does not remains on the page
	Then only a blouse remains in the table
Examples:
	| Browser |
	| Chrome  |
	| Edge    |

@Browser:Chrome
@Browser:Edge
Scenario Outline: 7) the user able to send message to support
	Given the site is opened in the '<Browser>'
	And the user enters 'T-shirt' in search-field on the base page
	And the user clicks on the search button
	And the user presses 'More' button for the first item on the products page
	And the user clicks on Send to a friend button
	And the user feels Name of friend field
	And the user feels E-mail field
	When the user clicks Send button
	Then appears success message Your e-mail has been sent successfully
Examples:
	| Browser |
	| Chrome  |
	| Edge    |

@Browser:Chrome
@Browser:Edge
Scenario Outline: 8) the user can send message to site team
	Given the site is opened in the '<Browser>'
	And the user clicks on Contact Us button on the base page
	And the user choices Customer service in Subject Heading dropdown
	And the user feels the Email address field
	And the user feels the Order reference field
	And the user feels text area message
	When the user clicks on the Send button
	Then success message is displayed
Examples:
	| Browser |
	| Chrome  |
	| Edge    |

@Browser:Chrome
@Browser:Edge
Scenario Outline: 9) when the user feels Newsletter field and clicks enter appears success message " Newsletter : You have successfully subscribed to this newsletter."
	Given the site is opened in the '<Browser>'
	When the user enters email in Newsletter field
	Then success message has appeared
Examples:
	| Browser |
	| Chrome  |
	| Edge    |













	      

