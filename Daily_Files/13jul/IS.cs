// I - Interface Segregation Principle (ISP)
// Clients should not be forced to implement methods
// they do not use

using System;

interface IWorkable
{
    void Work();
    void Walk();
}

interface IEatable
{
    void Eat();
}

class Human : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("Human is Working");
    }

    public void Walk()
    {
        Console.WriteLine("Human is Walking");
    }

    public void Eat()
    {
        Console.WriteLine("Human is Eating");
    }
}

class Robot : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot is Working");
    }

    public void Walk()
    {
        Console.WriteLine("Robot is Walking");
    }
}