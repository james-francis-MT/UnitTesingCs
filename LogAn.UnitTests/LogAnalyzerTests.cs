using NUnit.Framework;
using FluentAssertions;

namespace UnitTestingCs
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            result.Should().BeFalse();

        }
        [Test]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue(){
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithgoodextension.SLF");
            result.Should().BeTrue();
        }
    }
}