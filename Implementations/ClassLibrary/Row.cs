using System.Collections.Generic;
using System.Linq;

namespace CsvJsonPipeline 
{
    public class Row : IRow
    {
        public Row(int rowId, IEnumerable<IKeyPair> pairs)
        {
            RowId = rowId;
            Pairs = pairs;
        }
        public int RowId { get; set; }

        public IEnumerable<IKeyPair> Pairs{ get; set; }

        public string ToJson()
        {
            var jsonArray = Pairs.Select(value => value.ToJson()).ToArray();
            var middleJson = string.Join(", ", jsonArray);
            var outJson = "{\"row\":"+ RowId +",\"pairs\":[" + middleJson + "]}";
            return outJson;
        }
    }
}