using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyParser;
using DependencyParser.Interfaces;
using Xunit.Sdk;

namespace DependencyParser.Tests
{
    [TestClass()]
    public class DependencyParserBaseTests
    {
        private List<IPackageInfoItem> testItems = new()
            {
                new PackageInfoItem("Test NPM Package","1.0.0.0", Enums.PackageSource.NPM)
                {
                    MaxVersion = new Version(2, 0, 0, 0),
                },
                new PackageInfoItem("Test Nuget Package", "1.0.0.0", Enums.PackageSource.Nuget)
                {
                    MaxVersion = new Version(2, 0, 0, 0),
                }
            };

        private List<IPackageInfoItem> emptyItems = new List<IPackageInfoItem>();

        private class TestParser : DependencyParserBase { }
        private TestParser _parserBase;

        public DependencyParserBaseTests()
        {
            _parserBase = new TestParser();
        }

        [TestMethod()]
        public async Task WriteCSVFileAsyncTestSucceeds()
        {
            await DependencyParserBase.WriteCSVFileAsync(@"c:\temp\test.csv", testItems);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task WriteCSVFileAsyncWithNoPathThrowsArgumentException()
        {
            await DependencyParserBase.WriteCSVFileAsync(@"", testItems);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task WriteCSVFileAsyncWithNoItemsThrowsArgumentException()
        {
            await DependencyParserBase.WriteCSVFileAsync(@"c:\temp\test.csv", emptyItems);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task WriteCSVFileAsyncWithNullItemsThrowsArgumentException()
        {
            await DependencyParserBase.WriteCSVFileAsync(@"c:\temp\test.csv", null);
        }

        [TestMethod()]
        public void HygieneStringTest()
        {
            string dirtyString = @"\test123\\testabc""";
            string cleanString = @"test123testabc";

            var processedString = _parserBase.HygieneString(dirtyString);
            Assert.AreEqual(cleanString, processedString);
        }

        [TestMethod]
        public void SingleDigitVersionReturnsCorrectedVersion()
        {
            var processedVersion = _parserBase.HygieneVersion("1");
            Assert.AreEqual("1.0.0", processedVersion);
        }
        
        [TestMethod]
        public void HyphenatedVersionReturnsCorrectedVersion()
        {
            var processedVersion = _parserBase.HygieneVersion("1-0");
            Assert.AreEqual("1.0.0", processedVersion);
        }

        [TestMethod]
        public void NullVersionReturnsDefaultVersion()
        {
            var processedVersion = _parserBase.HygieneVersion("");
            Assert.AreEqual(PackageInfoItem.DEFAULT_VERSION_NUMBER, processedVersion);
        }
    }
}