using System.Collections.Generic;
using System.Linq;

namespace CsvJsonPipeline 
{
    public class DataFile : IDataFile
    {
        public DataFile (IEnumerable<IRow> rows)
        {
            Rows = rows;
        }

        public IEnumerable<IRow> Rows{ get; set;}

        public string ToJson()
        {
            var jsonArray = Rows.Select(value => value.ToJson()).ToArray();
            var middleJson = string.Join(", ", jsonArray);
            var outJson = "{\"rows\":[" + middleJson + "]}";
            return outJson;
        }
    }
}