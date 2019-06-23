using System;
using System.IO;
using System.Collections.Generic;

namespace CsvJsonPipeline 
{
    public class FileReader 
    {
        public static IEnumerable<String> readFile(string inFile)
        {
            return File.ReadAllLines(inFile);
        }

    }
}