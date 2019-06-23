using System.Collections.Generic;
using System.Linq;

namespace CsvJsonPipeline 
{
    public class CsvToDataFile
    {
        //creates a data row object from a csv file input
        public static DataFile CreateDataFile(IEnumerable<string> lines)
        {
            //split off the header line
            var header = lines.First().Split(',');
            //get the rest of the data
            var data = lines.Skip(1);
            //create the rows 
            var rows = data.Select((row,i) => CsvToRow.CreateRow(i,header,row));
            //create the data file
            var DataFile = new DataFile(rows);
            //return the data file
            return DataFile;
        }
    }
}