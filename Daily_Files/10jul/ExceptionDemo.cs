//exception handling prevents a program crashing when error occurs 
// try - risky code 
// catch(Exception e) - handle the exception 
// finally - always executes
//throw 

using System;
class ExceptionDemo
{
    static void CheckAge(int Age)
    {
        if (Age < 20)
        {
            throw new Exception("Not Eligible for placement");
        }
        Console.WriteLine("Can Attend Placement");
    }
    static void Main()
    {
        try
        {
            int a = 50;
            int b = 0;
            int c= a/b;
            Console.WriteLine(c);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        try{
            CheckAge(25);
        }

        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
         finally
        {
            Console.WriteLine("Program Finished.");
        }
    }
}