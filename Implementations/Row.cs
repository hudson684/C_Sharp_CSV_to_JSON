using System.Collections.Generic;
using System.Linq;

public class Row : IRow
{
    private int _rowId;
    private IEnumerable<IKeyPair> _pairs;

    public Row(int rowId, IEnumerable<IKeyPair> Pairs)
    {
        _rowId = rowId;
        _pairs = Pairs;
    }

    public Row(int rowId, string[] header, string data)
    {
        _rowId = rowId;
        var rawPairs = data.Split(',');
        _pairs = header.Select((headvalue, i) => new KeyPair(headvalue, rawPairs[i]));
    }

    public int RowId{
        get { return _rowId;}
        set { _rowId = value; }
    }

    public IEnumerable<IKeyPair> Pairs{
        get { return _pairs;}
        set { _pairs = value; }
    }

    public string ToJson()
    {
        var jsonArray = _pairs.Select(value => value.ToJson()).ToArray();
        var middleJson = string.Join(", ", jsonArray);
        var outJson = "{\"row\":"+ _rowId +",\"pairs\":[" + middleJson + "]}";
        return outJson;
    }
}