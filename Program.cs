using System;
using System.IO;


namespace CsvJsonPipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            string inFile = ErrorHandler.InFileTry(args);
            string outFile = ErrorHandler.OutFileTry(args);
        
            //read input file
            var lines = FileReader.readFile(inFile);
            //make data
            DataFile data = CsvToDataFile.CreateDataFile(lines);
            //write output file
            FileWriter.writeFile(outFile, data.ToJson());
        }
    }  
}


