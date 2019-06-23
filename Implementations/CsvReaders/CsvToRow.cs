using System.Collections.Generic;
using System.Linq;

namespace CsvJsonPipeline 
{
    public class CsvToRow
    {
        //creates a row from a single csv line and the csv headers. includes the row id.
        public static Row CreateRow(int rowId, string[] header, string data)
        {
            //split a row into it's composite lines
            var rawPairs = data.Split(',');
            //create the key pairs
            var pairs = header.Select((headvalue, i) => new KeyPair(headvalue, rawPairs[i]));
            //return the row
            return new Row(rowId, pairs);
        }
    }
}