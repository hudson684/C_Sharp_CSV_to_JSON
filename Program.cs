using System;
using System.IO;


namespace CsvJsonPipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            ErrorHandler err = new ErrorHandler();
            string inFile = err.InFileTry(args);
            string outFile = err.OutFileTry(args);
        
            //read input file
            var lines = File.ReadLines(inFile);
            //make data
            DataFile data = new DataFile(lines);
            //write output file
            File.WriteAllText(outFile, data.ToJson());
        }
    }  
}


