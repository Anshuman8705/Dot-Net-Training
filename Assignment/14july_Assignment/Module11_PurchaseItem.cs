using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 11: Purchase Item
// The spec says "Purchase module should implement it [IBill]", so
// the class that implements the interface is here.
// ==================================================================
class PurchaseService : IBill
{
    private const double GstRate = 0.18; // 18% GST

    // The actual body for the method promised by IBill.
    public void GenerateBill(StationeryItem item, int purchaseQty, double discount)
    {
        double amountBeforeTax = (item.Price * purchaseQty) - discount;
        double gst = amountBeforeTax * GstRate;
        double total = amountBeforeTax + gst;

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Item\t\tPrice\tQty\tDiscount\tGST\tTotal");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(
            item.ItemName + "\t" + item.Price.ToString("0.00") + "\t" +
            purchaseQty + "\t" + discount.ToString("0.00") + "\t\t" +
            gst.ToString("0.00") + "\t" + total.ToString("0.00"));
        Console.WriteLine("--------------------------------------------------");
    }

    // Reduces stock, works out the discount (Polymorphism decides which
    // child class's CalculateDiscount() actually runs) and prints the bill.
    public void PurchaseItem(StationeryItem item, int purchaseQty)
    {
        if (purchaseQty > item.Quantity)
            throw new InsufficientStockException("Purchase quantity exceeds available stock.");

        item.Quantity = item.Quantity - purchaseQty;

        double discount = item.CalculateDiscount();

        GenerateBill(item, purchaseQty, discount);
    }
}

static class Module11_PurchaseItem
{
    public static void Run(List<StationeryItem> items)
    {
        try
        {
            Console.Write("Enter Item Id: ");
            int id = InputHelper.ReadInt();

            StationeryItem item = items.FirstOrDefault(i => i.ItemId == id);
            if (item == null)
                throw new ItemNotFoundException("Item not found.");

            Console.Write("Enter Quantity: ");
            int qty = InputHelper.ReadInt();

            PurchaseService service = new PurchaseService();
            service.PurchaseItem(item, qty);
        }
        catch (ItemNotFoundException ex) { Console.WriteLine("Error: " + ex.Message); }
        catch (InsufficientStockException ex) { Console.WriteLine("Error: " + ex.Message); }
    }
}
