using System.ComponentModel;

string sourcePath = @"C:\Csharp\CSharpStudy\FilesFileInfoIoException\FilesFileInfoIoException\FileOne.txt";
string sourcePathTwo = @"C:\Csharp\CSharpStudy\FilesFileInfoIoException\FilesFileInfoIoException\FileTwo.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(sourcePathTwo);
}
catch (IOException ex)
{
    Console.WriteLine("ERROR");
    Console.WriteLine(ex);
}

