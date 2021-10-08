Feature: UsingCalculatorDefectDensity
  In order to calculate defect density
  As a Software Quality Metric engineer
  I want to use my calculator to be able to calculate defect density

@DefectDensity
Scenario: Calculate the defect density
	Given I have a calculator
	When I have entered "30" and "10" into the calculator and press dd
	Then the defect density result should be "3"

@KSSI
Scenario: Calculate the KSSI
	Given I have a calculator
	When I have entered "30" and "10" and "10" into the calculator and press kssi
	Then the SSI result should be "30"