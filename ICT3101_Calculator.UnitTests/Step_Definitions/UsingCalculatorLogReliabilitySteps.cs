using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorLogReliabilitySteps
    {
        private Calculator _calculator;
        private double _result;
        public UsingCalculatorLogReliabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press cfil")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCfil(double p0, double p1, double p2)
        {
            _result = _calculator.CurrentFailureIntensityLogModel(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press anefl")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAnefl(double p0, double p1, double p2)
        {
            _result = _calculator.NumberExpectedFailuresLogModel(p0, p1, p2);
        }
        
        [Then(@"the current failure intensity \(log\) result should be ""(.*)""")]
        public void ThenTheCurrentFailureIntensityLogResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the number of expected failures result should be ""(.*)""")]
        public void ThenTheNumberOfExpectedFailuresResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
