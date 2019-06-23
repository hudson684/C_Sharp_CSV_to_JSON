using System;
using System.IO;
using System.Collections.Generic;

namespace CsvJsonPipeline 
{
    public class FileWriter : IFileWriter
    {
        public  void writeFile(string outFile, string outData)
        {
            File.WriteAllText(outFile, outData);
        }

    }
}