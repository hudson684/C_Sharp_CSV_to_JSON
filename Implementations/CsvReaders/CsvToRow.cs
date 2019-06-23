using System.Collections.Generic;
using System.Linq;

public class CsvToRow
{
    public static Row CreateRow(int rowId, string[] header, string data)
    {
        var rawPairs = data.Split(',');
        var pairs = header.Select((headvalue, i) => new KeyPair(headvalue, rawPairs[i]));
        return new Row(rowId, pairs);
    }
}