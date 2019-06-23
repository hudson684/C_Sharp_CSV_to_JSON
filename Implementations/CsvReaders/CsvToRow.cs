using System.Collections.Generic;
using System.Linq;

namespace CsvJsonPipeline 
{
    public class CsvToRow : IRowCreator
    {
        //creates a row from a single csv line and the csv headers. includes the row id.
        public IRow CreateRow(int rowId, string[] header, string data)
        {
            //split a row into it's composite lines
            var rawPairs = data.Split(',');
            //create the key pairs
            var pairs = header.Select((headvalue, i) => Factory.CreateKeyPair(headvalue, rawPairs[i]));
            //return the row
            return Factory.CreateRow(rowId,pairs);
        }
    }
}