using System;
using System.Collections.Generic;

// ==================================================================
// Module 4: Display Vehicles (menu option "View All Vehicles")
// ==================================================================
static class Module4_DisplayVehicles
{
    public static void Run(List<Vehicle> vehicles)
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("No vehicles found.");
            return;
        }

        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("ID\tName\tBrand\tType\tPrice");
        Console.WriteLine("----------------------------------------------------");
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayDetails();
        }
    }
}
