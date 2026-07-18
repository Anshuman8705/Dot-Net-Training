using System;

class Program
{
    static void Main()
    {
        int totalPackages = 0;
        int qualityCheck = 0;
        int priority = 0;
        int normal = 0;

        for (int i = 1001; i <= 1020; i++)
        {
            totalPackages++;

            Console.Write("Package ID " + i + " : ");

            if (i % 4 == 0)
            {
                Console.WriteLine("Quality Check Required");
                qualityCheck++;
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Priority Shipment");
                priority++;
            }
            else
            {
                Console.WriteLine("Normal Processing");
                normal++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Total Packages Processed = " + totalPackages);
        Console.WriteLine("Quality Check Required = " + qualityCheck);
        Console.WriteLine("Priority Shipments = " + priority);
        Console.WriteLine("Normal Packages = " + normal);
    }
}