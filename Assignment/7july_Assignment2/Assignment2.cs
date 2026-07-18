using System;

class Assignment2
{
    static void Main()
    {
        int totalPower = 0;
        int maintenance = 0;
        int normal = 0;
        int efficient = 0;

        for (int i = 1; i <= 30; i++)
        {
            int power = 80 + (i * 5);

            Console.Write("Light Number " + i + " : ");
            Console.Write(power + " W - ");

            totalPower = totalPower + power;

            if (power > 180)
            {
                Console.WriteLine("Maintenance Required");
                maintenance++;
            }
            else if (power >= 140 && power <= 180)
            {
                Console.WriteLine("Normal Operation");
                normal++;
            }
            else
            {
                Console.WriteLine("Energy Efficient");
                efficient++;
            }
        }

        double average = (double)totalPower / 30;

        Console.WriteLine();
        Console.WriteLine("Total Power Consumed = " + totalPower + " W");
        Console.WriteLine("Average Power Consumption = " + average + " W");
        Console.WriteLine("Maintenance Required = " + maintenance);
        Console.WriteLine("Normal Operation = " + normal);
        Console.WriteLine("Energy Efficient = " + efficient);
    }
}