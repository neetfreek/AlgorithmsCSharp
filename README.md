# AlgorithmsCSharp
This library is project for me to better organise various functionality. Currently includes arrays.

This solution contains two projects:
- `AlgorithmsLibrary.csproj`(.NET Standard 2.0) library contains algorithm functionality organised into folders:
  - `ArrayInt` conains functionalty for integer JaggedArrays and Matrices.   
  - `ArrayIntChar` contains functionalty for character, integer vectors. 
  - `Common` contains helper classes for general functionality.
  - `Sort` contains sorting functionality, currently only Selection Sort.
- `ConsoleApp.csproj` (.NET Framework 4.71) client program to test algorithms with console.
  - `Program.cs` contains test methods for testing AlgorithmLibrary functionality.
