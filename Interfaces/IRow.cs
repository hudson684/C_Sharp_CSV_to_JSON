using System.Collections.Generic;

public interface IRow : IJsonable
{
   int RowId { get; set; }
   IEnumerable<IKeyPair> Pairs { get; set; }
}
