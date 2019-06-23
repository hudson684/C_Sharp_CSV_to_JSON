namespace CsvJsonPipeline 
{
   public interface IRowCreator
   {
      IRow CreateRow(int rowId, string[] header, string data);
   }
}