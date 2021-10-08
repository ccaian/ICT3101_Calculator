Feature: UsingCalculatorAdditions
	Simple calculator for adding two numbers
#
#@mytag
#Scenario: Add two numbers
#	Given the first number is 50
#	And the second number is 70
#	When the two numbers are added
#	Then the result should be 120

@Addition
Scenario: Add two numbers
Given I have a calculator
When I have entered "120" and "60" into the calculator and press add
Then the result should be "180"

@Addition
Scenario Outline: Add zeros for special cases
Given I have a calculator
When I have entered "<value1>" and "<value2>" into the calculator and press add
Then the result should be "<value3>"
Examples: 
|value1 |value2 |value3 |
|1 |11 |7 |
|10 |11 |11 |
|11 |11 |15 |
