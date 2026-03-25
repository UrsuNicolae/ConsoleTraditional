using ConsoleAppTraditional.UTs;
using Moq;

namespace ConsoleTests
{
    public class FileProcessorTests
    {
        [Theory]
        [InlineData("\n\n\n\n\n")]
        [InlineData("\n123\n123123\ndsfsadf\n12312\n")]
        public void CountLinesInFileShouldReturnExactNrOfLines(string returnedValue)
        {
            var fileReaderMock = new Mock<IFileReader>();
            fileReaderMock.Setup(_ => _.ReadFile(It.IsAny<string>())).Returns(returnedValue);
            var fileProcessor = new FileProcessor(fileReaderMock.Object);

            var nrOfLines = fileProcessor.CountLinesInFile("");

            fileReaderMock.Verify(_ => _.ReadFile(""), Times.Once);
            Assert.Equal(returnedValue.Split('\n').Length, nrOfLines);
        }

        [Theory]
        [InlineData("\n\n\n\n\n")]
        [InlineData("\n123\n123123\ndsfsadf\n12312\n")]
        public void CountLinesInFileShouldThrouwNullReferenceExceptionIfFileDoesntExist(string returnedValue)
        {
            var fileReaderMock = new Mock<IFileReader>();
            fileReaderMock.Setup(_ => _.ReadFile(It.IsAny<string>())).Returns<string>(null);
            var fileProcessor = new FileProcessor(fileReaderMock.Object);

            Assert.Throws<NullReferenceException>(() => fileProcessor.CountLinesInFile(""));
        }

        [Theory]
        [InlineData("\n\n\n\n\n")]
        [InlineData("\n123\n123123\ndsfsadf\n12312\n")]
        public void CountLinesInFileShouldThrowFileNotFoundExceptionIfFileIsNotAtGivenPath(string returnedValue)
        {
            var fileReaderMock = new Mock<IFileReader>();
            fileReaderMock.Setup(_ => _.ReadFile(It.IsAny<string>())).Throws(new FileNotFoundException());
            var fileProcessor = new FileProcessor(fileReaderMock.Object);

            Assert.Throws<FileNotFoundException>(() => fileProcessor.CountLinesInFile(""));
        }
    }
}
