using System;
public class Abstracteg : FileStorage
{
    public override void Upload(string filename)
    {
        Console.WriteLine("Uploading file : " + filename);
    }
}