using System.Runtime.CompilerServices;
using FilesAndDirectories;

Console.WriteLine("Specify the path to the directory");
string Path = Console.ReadLine();

try
{
    Process(Path);
}

catch (IndexOutOfRangeException)
{
    Console.WriteLine("There are no files in the directory");
    throw;
}

catch (DirectoryNotFoundException)
{
    Console.WriteLine("Directory not found");
    throw;
}

catch (IOException)
{
    Console.WriteLine("Invalid directory name");
    throw;
}


void Process(string path)
{
    path = Path;
    DirectoryInfo directoryInfo = new DirectoryInfo(path);
    var allFiles = directoryInfo.GetFiles("*.txt");
    allFiles.Sort();
    string filePath = allFiles[0].FullName;
    var text = File.ReadAllText(filePath);
    Console.WriteLine(text);
    
}