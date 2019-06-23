using System.Collections.Generic;
using System.Linq;

namespace CsvJsonPipeline 
{
    public class CsvToDataFile : IDataFileCreator
    {
        private IRowCreator _rowCreator;
        //creates a data row object from a csv file input

        public CsvToDataFile(IRowCreator rowCreator)
        {
            _rowCreator = rowCreator;
        }

        public IDataFile CreateDataFile(IEnumerable<string> lines)
        {
            //split off the header line
            var header = lines.First().Split(',');
            //get the rest of the data
            var data = lines.Skip(1);
            //create the rows 
            var rows = data.Select((row,i) => _rowCreator.CreateRow(i,header,row));
            //return the data file
            return Factory.CreateDataFile(rows);
        }
    }
}