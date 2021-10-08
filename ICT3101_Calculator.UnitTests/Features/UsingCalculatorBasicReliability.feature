Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@currentfailureintensity
Scenario: Calculate Current Failure Intensity
	Given I have a calculator
	When I have entered "<value1>", "<value2>" and "<value3>" into the calculator and press cfi
	Then the current failure intensity result should be "<value4>"
Examples: 
|value1 |value2 |value3 |value4 |
|1 |2 |3 |0.34 |

@averagenumberexpectedfailures
Scenario: Calculate Average Number of Expected Failures
	Given I have a calculator
	When I have entered "<value1>", "<value2>" and "<value3>" into the calculator and press anef
	Then the average number of expected failures result should be "<value4>"
Examples: 
|value1 |value2 |value3 |value4 |
|1 |2 |3 |1 |
