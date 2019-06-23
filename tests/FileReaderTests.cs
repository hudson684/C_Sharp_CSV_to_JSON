using Xunit;
using System.Linq;
using System.Collections.Generic;

public class FileReaderTests
{

    [Fact]
    public void FileReaderTest()
    {
        string inFile = "../../../tests/data/athletesTest.csv";
        var data = FileReader.readFile(inFile);
        string[] expected = new string[] {"firstName,lastName,middleName,dateOfBirth,sex,height,sport","Bob,Smith,John,30/08/1990,M,1.83,basketball","Sam,Peters, ,21/6/2000,F,1.79,rowing"};
        Assert.Equal(expected, data.ToArray());
    }

}