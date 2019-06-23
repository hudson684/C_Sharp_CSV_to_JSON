using System.Collections.Generic;

namespace CsvJsonPipeline
{
    public static class Factory 
    {
        public static IDataFile CreateDataFile(IEnumerable<IRow> rows)
        {
            return new DataFile(rows);
        }

        public static IRow CreateRow(int rowId, IEnumerable<IKeyPair> keyPairs)
        {
            return new Row(rowId, keyPairs);
        }

        public static IKeyPair CreateKeyPair(string name, string value)
        {
            return new KeyPair(name, value);
        }

        public static IDataFileCreator CreateDataFileCreator()
        {
            return new CsvToDataFile(CreateRowCreator());
        }

        public static IRowCreator CreateRowCreator()
        {
            return new CsvToRow();
        }

        public static IFileReader CreateFileReader()
        {
            return new FileReader();
        }

        public static IFileWriter CreateFileWriter()
        {
            return new FileWriter();
        }




    }
}