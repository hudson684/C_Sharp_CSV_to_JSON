using System;
public class ErrorHandler : IErrorHandler
{
    public string InFileTry(string[] args)
    {
        string inFile;
        try
        {
            inFile = args[0];
        }
        catch (System.IndexOutOfRangeException)
        {
            Console.WriteLine("#########################################################################");
            Console.WriteLine("#########################################################################");
            Console.WriteLine("Hello! This console requires to arguments and is missing both of them.");
            Console.WriteLine("Argument 1 should be the file path to the input .csv file");
            Console.WriteLine("Argument 2 should be the file path to the output .json file");
            Console.WriteLine("#########################################################################");
            Console.WriteLine("#########################################################################");
            throw new Exception("Missing Input Arugments");
        }

        return inFile;
    }

    public string OutFileTry(string[] args)
    {
        string outFile;
        try
        {
            outFile = args[1];
        }
        catch (System.IndexOutOfRangeException)
        {
            Console.WriteLine("#########################################################################");
            Console.WriteLine("#########################################################################");
            Console.WriteLine("Hello! This console requires to arguments and is missing the second.");
            Console.WriteLine("Argument 1 should be the file path to the input .csv file");
            Console.WriteLine("Argument 2 should be the file path to the output .json file");
            Console.WriteLine("#########################################################################");
            Console.WriteLine("#########################################################################");
            
            throw new Exception("Missing Second input arugment");
        }
        return outFile;

    }
}
