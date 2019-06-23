using Xunit;
using System.Linq;

namespace CsvJsonPipeline 
{
    public class DataFileTests
    {
        static IRowCreator rowCreator = Factory.CreateRowCreator();
        private static string[] headers = new string[] {"name", "age"};
        private static string data = "John,20";
        private static IRow testRow = rowCreator.CreateRow(0, headers, data);
        private static IRow testRow2 = rowCreator.CreateRow(1, headers, data);
        private IRow[] testRows = new IRow[] {testRow};

        [Fact]
        public void DataFile_Constructor_Two_Pass()
        {
            DataFile testDataFile = new DataFile(testRows);
            Assert.Equal(testRows,testDataFile.Rows);
        }

        [Fact]
        public void DataFile_Double_ToJson()
        {
            string expected = "{\"rows\":[{\"row\":0,\"pairs\":[{\"key\":\"name\",\"value\":\"John\"}, {\"key\":\"age\",\"value\":\"20\"}]}]}";
            DataFile testDataFile = new DataFile(testRows);
            Assert.Equal(expected,testDataFile.ToJson());
        }
    }
}