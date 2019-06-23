using Xunit;

namespace CsvJsonPipeline 
{
    public class KeyPairTests
    {
        KeyPair testNormalKeyPair = new KeyPair("name", "john");

        [Fact]
        public void KeyPair_Value_Set_Constructor_Pass()
        {
            string expected = "john";
            Assert.Equal(expected, testNormalKeyPair.Value);
        }

        [Fact]
        public void KeyPair_Name_Set_Constructor_Pass()
        {
            string expected = "name";
            Assert.Equal(expected, testNormalKeyPair.Key);
        }

        [Fact]
        public void KeyPair_Output_Pass()
        {
            string expected = "{\"key\":\"name\",\"value\":\"john\"}";

            Assert.Equal(expected, testNormalKeyPair.ToJson());
        }
    }
}