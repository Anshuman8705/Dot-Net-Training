using System;

delegate void MessageDelegate(string message);

class Delegates
{
    static void Display(string message)
    {
        Console.WriteLine("Method1 : " + message);
    }

    static void Display1(string message)
    {
        Console.WriteLine("Method2 : " + message);
    }

    static void Display2(string message)
    {
        Console.WriteLine("Method3 : " + message);
    }

    static void Main()
    {
        // Built-in delegate Func
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(5, 3));

        MessageDelegate m;

        m = Display;
        //m += Display1;
        m += Display2;

        m("Hello");

        Button bt = new Button();
        bt.Click +=() => Console.WriteLine("Click Event");
        bt.Press();
        
    }
}