using System;

// A small shared helper so every module can safely read numbers
// without crashing on bad input. Not one of the numbered modules -
// just a convenience a few modules reuse.
static class InputHelper
{
    public static int ReadInt()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Please enter a valid number: ");
        }
        return result;
    }

    public static double ReadDouble()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Please enter a valid number: ");
        }
        return result;
    }
}
