Feature: CalTable

@mytag1
Scenario: Add two numbers
	Given the numbers are 
	| Numbers |
	| 50      |
	| 87      |
	When adds two numbers
	Then result of addition 147

	Given numbers with sign
	| Numbers2 | sign  |
	| 75       | plus  |
	| 87       | minus |
	When adds next two numbers
	Then result of second addition 162

	Given the number
	| Numbers2 | sign |
	| 75       | plus |
	Then result should be "positive"


Scenario Outline: Adding two numbers
	Given numbers are <N1> and <N2>
	Examples: 
	| N1 | N2 |
	| 48 | 43 |
	| 93 | 17 |
