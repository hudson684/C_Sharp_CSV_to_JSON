using System;
using System.IO;
using System.Collections.Generic;

namespace CsvJsonPipeline 
{
    public class FileWriter
    {
        public static void writeFile(string outFile, string outData)
        {
            File.WriteAllText(outFile, outData);
        }

    }
}