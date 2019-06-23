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
            IFileReader fileReader = Factory.CreateFileReader();
            var lines = fileReader.readFile(inFile);
            //make data
            IDataFileCreator dataFileCreator = Factory.CreateDataFileCreator();
            IDataFile data = dataFileCreator.CreateDataFile(lines);
            //write output file
            IFileWriter fileWriter = Factory.CreateFileWriter();
            fileWriter.writeFile(outFile, data.ToJson());
        }
    }  
}


