//delegate - type that holds a reference to a method with a specific signature
//similar to function pointer in C/C++
using System;
// built in delegate func
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine($"Addition: {add(5, 3)}");

delegate void MessageDelegate(string message);

class Delegates
{
    static void Display (string message)
    {
        Console.WriteLine(message);
    }
    static void Main()
    {
        MessageDelegate m = Display;
        m("Hello, World!");
    }
}
