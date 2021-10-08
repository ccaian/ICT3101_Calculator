using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialsSteps
    {
        private Calculator _calculator;
        private double _result;
        //Context Injection for SpecFLow:
        public UsingCalculatorFactorialsSteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------
        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(double p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
