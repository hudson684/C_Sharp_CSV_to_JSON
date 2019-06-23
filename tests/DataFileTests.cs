using Xunit;
using System.Linq;

public class DataFileTests
{
    private static string[] headers = new string[] {"name", "age"};
    private static string data = "John,20";
    private static Row testRow = CsvToRow.CreateRow(0, headers, data);
    private static Row testRow2 = CsvToRow.CreateRow(1, headers, data);
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