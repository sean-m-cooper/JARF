using Xunit;

namespace DependencyParser.Tests
{
    [TestClass()]
    public class FileWriterTests
    {
        private string filePath = @"c:\temp\test.csv";
        private readonly FileWriter fileWriter;

        private string[] testLines = new string[] { "This is a test.", "This is another test." };

        public FileWriterTests()
        {
            {
                fileWriter = new FileWriter(filePath);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
        }

        [TestMethod]
        public async Task WriteFileAsyncWithOvewritePasses()
        {
            await fileWriter.WriteFileAsync(testLines);
        }

        [TestMethod]
        public async Task WriteFileAsyncOvewriteSucceeds()
        {
            await fileWriter.WriteFileAsync(testLines);
            await fileWriter.WriteFileAsync(testLines);
        }
    }
}