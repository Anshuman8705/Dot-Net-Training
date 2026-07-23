using System;
using System.Collections.Generic;

// ==================================================================
// Module 2: Main Menu
// The List<Vehicle> lives here (see Module 3) and is passed to
// whichever module the user picks.
// ==================================================================
static class Module2_MainMenu
{
    public static void Run()
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        int choice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("ABC MOTORS");
            Console.WriteLine("Vehicle Management System");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. View All Vehicles");
            Console.WriteLine("3. Search Vehicle");
            Console.WriteLine("4. Update Vehicle Price");
            Console.WriteLine("5. Delete Vehicle");
            Console.WriteLine("6. Calculate Discount");
            Console.WriteLine("7. Show Vehicle Details");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");

            choice = InputHelper.ReadInt();

            switch (choice)
            {
                case 1: Module3_AddVehicle.Run(vehicles); break;
                case 2: Module4_DisplayVehicles.Run(vehicles); break;
                case 3: Module5_SearchVehicle.Run(vehicles); break;
                case 4: Module6_UpdatePrice.Run(vehicles); break;
                case 5: Module7_DeleteVehicle.Run(vehicles); break;
                case 6: Module8_CalculateDiscount.Run(vehicles); break;
                case 7: Module9_ShowVehicleDetails.Run(); break;
                case 8: Module10_Exit.Run(); break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        } while (choice != 8);
    }
}
