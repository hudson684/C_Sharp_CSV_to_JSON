using Xunit;
using System.Linq;

namespace CsvJsonPipeline 
{
    public class RowTests
    {

        //reusable variables.
        private static IKeyPair keyPairA = new KeyPair("name", "John");
        private static IKeyPair keyPairB = new KeyPair("age", "20");
        private IKeyPair[] keyArray = new IKeyPair[] {keyPairA, keyPairB};
        private int GenericId = 0;

        // constructor tests
        [Fact]
        public void Row_Constructor_Pairs_Pass()
        {
            Row testRow = new Row(GenericId, keyArray);
            Assert.Equal(keyArray, testRow.Pairs);
        }

        [Fact]
        public void Row_Constructor_Id_Pass()
        {
            Row testRow = new Row(GenericId, keyArray);
            Assert.Equal(GenericId, testRow.RowId);
        }

        //To Json tests
        [Fact]
        public void Row_Constructor_toJson_Pass()
        {
            Row testRow = new Row(GenericId, keyArray);
            string actual = testRow.ToJson();
            string expected = "{\"row\":0,\"pairs\":[{\"key\":\"name\",\"value\":\"John\"}, {\"key\":\"age\",\"value\":\"20\"}]}";
            Assert.Equal(expected, actual);
        }
    }
}