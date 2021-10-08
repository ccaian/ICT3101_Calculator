Feature: UsingCalculatorFactorials
	In order to calculate the factorial of a number
	As a System Quality Engineers
	I want my calculator to do this

@factorial
Scenario: Factorial a number
	Given I have a calculator
	When I have entered "5" into the calculator and press factorial
	Then the factorial result should be "120"

@factorialzero
Scenario: Factorial a zero
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the factorial result should be "1"
