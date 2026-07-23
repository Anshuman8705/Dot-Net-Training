using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 10: Delete Item
// ==================================================================
static class Module10_DeleteItem
{
    public static void Run(List<StationeryItem> items)
    {
        try
        {
            Console.Write("Enter Item Id to delete: ");
            int id = InputHelper.ReadInt();

            StationeryItem item = items.FirstOrDefault(i => i.ItemId == id);
            if (item == null)
                throw new ItemNotFoundException("Item not found.");

            Console.Write("Delete ? Y/N: ");
            string confirm = Console.ReadLine();

            if (confirm.Trim().ToUpper() == "Y")
            {
                items.Remove(item);
                Console.WriteLine("Item deleted successfully.");
            }
            else
            {
                Console.WriteLine("Delete cancelled.");
            }
        }
        catch (ItemNotFoundException ex) { Console.WriteLine("Error: " + ex.Message); }
    }
}
