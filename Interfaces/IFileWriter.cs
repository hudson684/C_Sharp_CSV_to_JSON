using System.Collections.Generic;

namespace CsvJsonPipeline 
{
    public interface IFileWriter
    {
        void writeFile(string outFile, string outData);
    }
}