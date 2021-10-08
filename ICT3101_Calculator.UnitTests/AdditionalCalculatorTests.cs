using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;
using Moq;

namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;
        String path = Path.Combine(Directory.GetCurrentDirectory(), "MagicNumbers.txt");
        [SetUp] 
        public void Setup() 
        { 
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => 
                fr.Read(path)).Returns(new string[2]{ "42","42"});
            _calculator = new Calculator(); 
        }

        [Test]
        [TestCase(42)]
        public void GetMagicNumber_WhenInputNumber1_ReturnNumberInFile(int p0)
        {
            //IFileReader fileReader = new FileReader();
            IFileReader fileReader = _mockFileReader.Object;
            Assert.That(_calculator.GenMagicNum(p0, fileReader), Is.EqualTo(0));
        }
    }
}
