using System.Collections.Generic;

public interface IDataFile : IJsonable
{
   IEnumerable<IRow> Rows { get; set; }
}
