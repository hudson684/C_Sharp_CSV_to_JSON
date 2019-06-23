using System.Collections.Generic;

namespace CsvJsonPipeline 
{
    public interface IFileReader
    {
        IEnumerable<string> readFile(string inFile);   
    }
}