namespace ConsoleAppTraditional.UTs
{
    public interface IFileReader
    {
        string ReadFile(string filePath);
    }


    public class FileProcessor
    {
        private IFileReader _fileReader;


        public FileProcessor(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }


        public int CountLinesInFile(string filePath)
        {
            var fileContent = _fileReader.ReadFile(filePath);
            return fileContent.Split('\n').Length;
        }
    }

}
