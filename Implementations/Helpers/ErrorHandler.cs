using System;
namespace CsvJsonPipeline 
{
    public class ErrorHandler
    {
        public static string InFileTry(string[] args)
        {
            string inFile;
            try
            {
                inFile = args[0];
            }
            catch (System.IndexOutOfRangeException)
            {
                MissingArgumentMessage("both arguments");
                throw new Exception("Missing Input Arugments");
            }

            return inFile;
        }

        public static string OutFileTry(string[] args)
        {
            string outFile;
            try
            {
                outFile = args[1];
            }
            catch (System.IndexOutOfRangeException)
            {
                MissingArgumentMessage("the second argument");
                throw new Exception("Missing Second input arugment");
            }
            return outFile;
        }

        private static void MissingArgumentMessage (string missingLine)
        {
            Console.WriteLine("#########################################################################");
                Console.WriteLine("#########################################################################");
                Console.WriteLine($"Hello! This console requires two arguments and is missing {missingLine}.");
                Console.WriteLine("Argument 1 should be the file path to the input .csv file");
                Console.WriteLine("Argument 2 should be the file path to the output .json file");
                Console.WriteLine("#########################################################################");
                Console.WriteLine("#########################################################################");  
        }
    }
}
