using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Module1_Login.Run();
            Module2_MainMenu.Run();
        }
        catch (LoginFailedException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
