using Xunit;
using System.IO;

namespace CsvJsonPipeline 
{
    public class FileWriterTests
    {
        [Fact]
        public void File_Write_Pass_Test()
        {
            //set up variables
            string toWrite = "{\"key\"=\"test\", \"value\"=\"test\"}";
            string testLocation = "../../../tests/data/athletesTest.json";
            
            //write data
            IFileWriter fileWriter = Factory.CreateFileWriter();
            fileWriter.writeFile(testLocation, toWrite);

            //generic read data
            string expected = File.ReadAllText(testLocation);

            //assert equal
            Assert.Equal(expected, toWrite);
        }
    }
}