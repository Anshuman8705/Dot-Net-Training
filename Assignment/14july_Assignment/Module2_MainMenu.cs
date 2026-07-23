using System;
using System.Collections.Generic;

// ==================================================================
// Module 2: Main Menu
// This also covers Module 5 (List Collection): the List<StationeryItem>
// lives here and is passed to whichever module the user picks.
// ==================================================================
static class Module2_MainMenu
{
    public static void Run()
    {
        List<StationeryItem> items = new List<StationeryItem>();
        int choice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("     Stationery Store Management System");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1. Add Stationery Item");
            Console.WriteLine("2. Display All Items");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Update Item");
            Console.WriteLine("5. Delete Item");
            Console.WriteLine("6. Purchase Item");
            Console.WriteLine("7. View Low Stock Items");
            Console.WriteLine("8. Sort Items");
            Console.WriteLine("9. Exit");
            Console.Write("Enter Choice: ");

            choice = InputHelper.ReadInt();

            switch (choice)
            {
                case 1: Module6_AddItem.Run(items); break;
                case 2: Module7_DisplayItems.Run(items); break;
                case 3: Module8_SearchItem.Run(items); break;
                case 4: Module9_UpdateItem.Run(items); break;
                case 5: Module10_DeleteItem.Run(items); break;
                case 6: Module11_PurchaseItem.Run(items); break;
                case 7: Module12_LowStock.Run(items); break;
                case 8: Module13_Sorting.Run(items); break;
                case 9: Module14_Exit.Run(); break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        } while (choice != 9);
    }
}
