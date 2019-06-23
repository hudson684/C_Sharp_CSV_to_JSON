using Xunit;
using System.Linq;

public class DataFileTests
{
    private static string[] headers = new string[] {"name", "age"};
    private static string data = "John,20";
    private static Row testRow = new Row(0, headers, data);
    private static Row testRow2 = new Row(1, headers, data);
    private IRow[] testRows = new IRow[] {testRow};
    private IRow[] testRowsDouble = new IRow[] {testRow,testRow2};
    private string[] testLines = new string[] {"name,age","John,20","John,20"};

    // [Fact]
    // public void DataFile_Constructor_Pass()
    // {
    //     DataFile testDataFile = new DataFile(testLines);
    //     IRow[] actual = testDataFile.Rows.ToArray();
    //     Assert.Equal(testRowsDouble,actual);
    // }

    [Fact]
    public void DataFile_Constructor_Two_Pass()
    {
        DataFile testDataFile = new DataFile(testRows);
        Assert.Equal(testRows,testDataFile.Rows);
    }

    [Fact]
    public void DataFile_Single_ToJson()
    {
        string expected = "{\"rows\":[{\"row\":0,\"pairs\":[{\"key\":\"name\",\"value\":\"John\"}, {\"key\":\"age\",\"value\":\"20\"}]}, {\"row\":1,\"pairs\":[{\"key\":\"name\",\"value\":\"John\"}, {\"key\":\"age\",\"value\":\"20\"}]}]}";
        DataFile testDataFile = new DataFile(testLines);
        Assert.Equal(expected,testDataFile.ToJson());
    }

    [Fact]
    public void DataFile_Double_ToJson()
    {
        string expected = "{\"rows\":[{\"row\":0,\"pairs\":[{\"key\":\"name\",\"value\":\"John\"}, {\"key\":\"age\",\"value\":\"20\"}]}]}";
        DataFile testDataFile = new DataFile(testRows);
        Assert.Equal(expected,testDataFile.ToJson());
    }



}