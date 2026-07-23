// Events- based on delegates &used to notify other classes when something happens
using System;
class Button
{
    public event Action Click;
    public void Press()
    {
        Console.WriteLine("Button is Pressed");
        Click.Invoke();
    }

}