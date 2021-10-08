using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDefectDensitySteps
    {
        private Calculator _calculator;
        private double _result;
        public UsingCalculatorDefectDensitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press dd")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDd(int p0, int p1)
        {
            _result = _calculator.DefectDensity(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press kssi")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressKssi(int p0, int p1, int p2)
        {
            _result = _calculator.KSSI(p0, p1, p2);
        }

        [Then(@"the defect density result should be ""(.*)""")]
        public void ThenTheDefectDensityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the SSI result should be ""(.*)""")]
        public void ThenTheSSIResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
