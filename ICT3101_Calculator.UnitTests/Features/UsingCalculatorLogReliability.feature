Feature: UsingCalculatorLogReliability
	In order to calculate the Log Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@logcurrentfailureintensity
Scenario: Calculate Current Failure Intensity
	Given I have a calculator
	When I have entered "<value1>", "<value2>" and "<value3>" into the calculator and press cfil
	Then the current failure intensity (log) result should be "<value4>"
Examples: 
|value1 |value2 |value3 |value4 |
|10 |0.02 |50 |3.68 |

@lognumberoffailures
Scenario: Calculate Number of Expected Failures
	Given I have a calculator
	When I have entered "<value1>", "<value2>" and "<value3>" into the calculator and press anefl
	Then the number of expected failures result should be "<value4>"
Examples: 
|value1 |value2 |value3 |value4 |
|0.02 |10 |100 |152.23 |