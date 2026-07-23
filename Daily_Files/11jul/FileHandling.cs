using System;

using System.IO;

public class FileHandling
{
    static void Main()
    {
        File.WriteAllText("emp.txt", "nameof:Anshu");
        string data = File.ReadAllText("emp.txt");
        Console.WriteLine(data);
    }
}