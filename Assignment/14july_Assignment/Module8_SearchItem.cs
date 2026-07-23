using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 8: Search Item
// ==================================================================
static class Module8_SearchItem
{
    public static void Run(List<StationeryItem> items)
    {
        try
        {
            Console.WriteLine("Search by: 1-Item Id, 2-Item Name");
            int option = InputHelper.ReadInt();

            StationeryItem found = null;

            if (option == 1)
            {
                Console.Write("Enter Item Id: ");
                int id = InputHelper.ReadInt();
                found = items.FirstOrDefault(i => i.ItemId == id);
            }
            else if (option == 2)
            {
                Console.Write("Enter Item Name: ");
                string name = Console.ReadLine();
                found = items.FirstOrDefault(
                    i => i.ItemName.ToLower() == name.ToLower());
            }

            if (found == null)
                throw new ItemNotFoundException("Item not found.");

            found.DisplayDetails();
        }
        catch (ItemNotFoundException ex) { Console.WriteLine("Error: " + ex.Message); }
    }
}
