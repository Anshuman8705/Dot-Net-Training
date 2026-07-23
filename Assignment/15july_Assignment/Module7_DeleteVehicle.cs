using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 7: Delete Vehicle
// ==================================================================
static class Module7_DeleteVehicle
{
    public static void Run(List<Vehicle> vehicles)
    {
        Console.Write("Enter Vehicle ID: ");
        int id = InputHelper.ReadInt();

        Vehicle vehicle = vehicles.FirstOrDefault(v => v.VehicleId == id);

        if (vehicle == null)
        {
            Console.WriteLine("Vehicle not available.");
            return;
        }

        vehicles.Remove(vehicle);
        Console.WriteLine("Vehicle deleted successfully.");
    }
}
