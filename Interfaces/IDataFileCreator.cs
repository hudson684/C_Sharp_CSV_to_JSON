using System.Collections.Generic;

namespace CsvJsonPipeline 
{
   public interface IDataFileCreator
   {
      IDataFile CreateDataFile(IEnumerable<string> lines);
   }
}
