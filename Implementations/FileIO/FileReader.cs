using System;
using System.IO;
using System.Collections.Generic;

namespace CsvJsonPipeline 
{
    public class FileReader : IFileReader
    {
        public IEnumerable<string> readFile(string inFile)
        {
            return File.ReadAllLines(inFile);
        }

    }
}