# Data Pipeline Application
_By Joshua Hudson_

## Summary

This application takes a generic input .csv file and converts it to a keypair json file.

## Dependancies and assumptions

This program assumes that .net core app framework version 2.2 or later is installed.

This program was developed in VS Code with the following extensions:

* C# (powered by OmniSharp)
* NuGet Package Manager

The following packages are required to run this application

* Microsoft.Net.Test.Sdk version 16.2.0 or later
* xunit version 2.4.1 or later
* unit.runner.visualstudio version 2.4.1 or later

## How To Run

This program has two mandatory command line arguments.
These are as follows

1. Type: String - Description: The file path of the inbound file - the file must exist.
2. Type: String - Description: The file path of the outbound file - the file does not need to exist, if it does the program will override the file.

from the command line, or terminal, navigate to the main folder of this application then run the following

```cmd
dotnet build
dotnet run {argument 1} {argument 2}
```
