using Xunit;
using System.Linq;


public class RowTests
{

    //reusable variables.
    private string[] headers = new string[] {"name", "age"};
    private string data = "John,20";
    private static IKeyPair keyPairA = new KeyPair("name", "John");
    private static IKeyPair keyPairB = new KeyPair("age", "20");
    private IKeyPair[] keyArray = new IKeyPair[] {keyPairA, keyPairB};
    private int GenericId = 0;

    //constructor one tests
    //TODO: fix this test?
    // [Fact]
    // public void Row_Constructor_Pairs_Pass()
    // {
    //     Row testRow = new Row(GenericId, headers, data);
    //     var actual = testRow.Pairs.ToArray();
    //     Assert.Equal(keyArray, actual);
    // }

    [Fact]
    public void Row_Constructor_Id_Pass()
    {
        Row testRow = new Row(GenericId, headers, data);
        Assert.Equal(GenericId, testRow.RowId);
    }

    // constructor two tests
    [Fact]
    public void Row_Constructor_two_Pairs_Pass()
    {
        Row testRow = new Row(GenericId, keyArray);
        Assert.Equal(keyArray, testRow.Pairs);
    }

    [Fact]
    public void Row_Constructor_two_Id_Pass()
    {
        Row testRow = new Row(GenericId, keyArray);
        Assert.Equal(GenericId, testRow.RowId);
    }



    //To Json tests
    [Fact]
    public void Row_Constructor_toJson_Pass()
    {
        Row testRow = new Row(GenericId, headers, data);
        string actual = testRow.ToJson();
        string expected = "{\"row\":0,\"pairs\":[{\"key\":\"name\",\"value\":\"John\"}, {\"key\":\"age\",\"value\":\"20\"}]}";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Row_Constructor_Two_toJson_Pass()
    {
        Row testRow = new Row(GenericId, keyArray);
        string actual = testRow.ToJson();
        string expected = "{\"row\":0,\"pairs\":[{\"key\":\"name\",\"value\":\"John\"}, {\"key\":\"age\",\"value\":\"20\"}]}";
        Assert.Equal(expected, actual);
    }


}