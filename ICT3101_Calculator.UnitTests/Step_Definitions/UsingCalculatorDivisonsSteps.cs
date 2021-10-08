using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDivisonsSteps
    {
        private Calculator _calculator;
        private double _result;
        /*public UsingCalculatorDivisonsSteps()
        {
            _calculator = new Calculator();
        }*/

        //Context Injection for SpecFLow:
        public UsingCalculatorDivisonsSteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            
            _result = _calculator.Divide(p0, p1);
        }
        
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        //[Then(@"the division result should be ""(.*)""")]
        //public void ThenTheDivisionResultShouldBe(int p0)
        //{
        //    Assert.That(_result, Is.EqualTo(p0));
        //}
        
        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity)); 
        }
    }
}
