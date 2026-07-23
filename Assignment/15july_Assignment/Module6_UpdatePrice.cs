using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 6: Update Price
// ==================================================================
static class Module6_UpdatePrice
{
    public static void Run(List<Vehicle> vehicles)
    {
        Console.Write("Enter Vehicle ID: ");
        int id = InputHelper.ReadInt();

        Vehicle vehicle = vehicles.FirstOrDefault(v => v.VehicleId == id);

        if (vehicle == null)
        {
            Console.WriteLine("Vehicle ID does not exist.");
            return;
        }

        Console.Write("Enter New Price: ");
        vehicle.Price = InputHelper.ReadDouble();

        Console.WriteLine("Price updated successfully.");
    }
}
