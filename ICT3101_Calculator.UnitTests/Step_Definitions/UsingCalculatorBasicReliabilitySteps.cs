using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private Calculator _calculator;
        private double _result;
        public UsingCalculatorBasicReliabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press cfi")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCfi(double p0, double p1, double p2)
        {
            _result = _calculator.CurrentFailureIntensity(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press anef")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAnef(double p0, double p1, double p2)
        {
            _result = _calculator.AverageNumberExpectedFailures(p0, p1, p2);
        }

        [Then(@"the current failure intensity result should be ""(.*)""")]
        public void ThenTheCurrentFailureIntensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the average number of expected failures result should be ""(.*)""")]
        public void ThenTheAverageNumberOfExpectedFailuresResultShouldBe(double p0)
        {
            //to round up
            //double multiplier = Math.Pow(10, Convert.ToDouble(2));
            //p0 = Math.Ceiling(p0 * multiplier) / multiplier;
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
