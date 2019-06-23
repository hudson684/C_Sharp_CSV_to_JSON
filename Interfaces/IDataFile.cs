using System.Collections.Generic;

namespace CsvJsonPipeline 
{
   public interface IDataFile : IJsonable
   {
      IEnumerable<IRow> Rows { get; set; }
   }
}
