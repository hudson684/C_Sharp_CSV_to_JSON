using System.Collections.Generic;

namespace CsvJsonPipeline 
{
   public interface IRow : IJsonable
   {
      int RowId { get; set; }
      IEnumerable<IKeyPair> Pairs { get; set; }
   }
}
