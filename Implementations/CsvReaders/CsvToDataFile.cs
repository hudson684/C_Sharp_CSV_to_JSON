using System.Collections.Generic;
using System.Linq;

public class CsvToDataFile
{
    public static DataFile CreateDataFile(IEnumerable<string> lines)
    {
        var header = lines.First().Split(',');
        var data = lines.Skip(1);
        var rows = data.Select((row,i) => CsvToRow.CreateRow(i,header,row));
        var DataFile = new DataFile(rows);
        return DataFile;
    }
}