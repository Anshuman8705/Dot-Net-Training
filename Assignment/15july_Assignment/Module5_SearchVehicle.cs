using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 5: Search Vehicle
// ==================================================================
static class Module5_SearchVehicle
{
    public static void Run(List<Vehicle> vehicles)
    {
        Console.Write("Enter Vehicle ID: ");
        int id = InputHelper.ReadInt();

        Vehicle found = vehicles.FirstOrDefault(v => v.VehicleId == id);

        if (found == null)
        {
            Console.WriteLine("Vehicle not found.");
            return;
        }

        found.DisplayDetails();
    }
}
