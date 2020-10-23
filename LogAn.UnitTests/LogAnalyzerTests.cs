using NUnit.Framework;
using FluentAssertions;
using System;

namespace UnitTestingCs
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [TestCase("filewithbadextension.foo")]
        public void IsValidLogFileName_BadExtension_ReturnsFalse(string file){

            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(file);

            result.Should().BeFalse();

        }

        [TestCase("filewithgoodextension.SLF")]
        [TestCase("filewithgoodextension.slf")]
        public void IsValidLogFileName_ValidExtension_ReturnsTrue(string file){

            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(file);

            result.Should().BeTrue();

        }

        [Test]
        public void IsValidLogFileName_EmptyFileName_Throws(){
            LogAnalyzer la = new LogAnalyzer();

            Action act = () => la.IsValidLogFileName("");
            
            act.Should().Throw<Exception>()
            .WithMessage("filename has to be provided");
        }
    }
}