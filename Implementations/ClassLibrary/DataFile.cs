using System.Collections.Generic;
using System.Linq;

public class DataFile : IDataFile
{
    private IEnumerable<IRow> _rows;
    
    public DataFile (IEnumerable<IRow> rows)
    {
        _rows = rows;
    }

    public IEnumerable<IRow> Rows{
        get { return _rows;  }
        set { _rows = value; }
    }

    public string ToJson()
    {
        var jsonArray = _rows.Select(value => value.ToJson()).ToArray();
        var middleJson = string.Join(", ", jsonArray);
        var outJson = "{\"rows\":[" + middleJson + "]}";
        return outJson;
    }
}