using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 3: Vehicle Details (menu option "Add Vehicle")
// Takes the vehicle's details from the user and stores it in the
// shared List<Vehicle>.
// ==================================================================
static class Module3_AddVehicle
{
    public static void Run(List<Vehicle> vehicles)
    {
        Console.Write("Vehicle ID : ");
        int id = InputHelper.ReadInt();

        // Keep Vehicle Ids unique, same idea as the Stationery project
        if (vehicles.Any(v => v.VehicleId == id))
        {
            Console.WriteLine("A vehicle with this ID already exists.");
            return;
        }

        Console.Write("Vehicle Name : ");
        string name = Console.ReadLine();

        Console.Write("Vehicle Type (Car/Bike/Truck) : ");
        string type = Console.ReadLine();

        Console.Write("Brand : ");
        string brand = Console.ReadLine();

        Console.Write("Price : ");
        double price = InputHelper.ReadDouble();

        Console.Write("Year : ");
        int year = InputHelper.ReadInt();

        Vehicle vehicle = new Vehicle
        {
            VehicleId = id,
            VehicleName = name,
            VehicleType = type,
            Brand = brand,
            Price = price,
            ManufacturingYear = year
        };

        vehicles.Add(vehicle);
        Console.WriteLine("Vehicle added successfully.");
    }
}
