using System;
using System.Collections.Generic;

namespace ShopEaseApp
{
    // Module 5 - Order Module
    // Simple class to hold order details, generated at checkout
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string CustomerName { get; set; }
        public List<CartItem> Items { get; set; }
        public double Total { get; set; }
        public double GST { get; set; }
        public double Discount { get; set; }
        public double GrandTotal { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string OrderStatus { get; set; }

        public Order(int orderId, string customerName, List<CartItem> items,
                      double total, double gst, double discount, double grandTotal,
                      string address, string paymentMethod, string paymentStatus)
        {
            OrderId = orderId;
            Date = DateTime.Now;
            CustomerName = customerName;
            Items = items;
            Total = total;
            GST = gst;
            Discount = discount;
            GrandTotal = grandTotal;
            Address = address;
            PaymentMethod = paymentMethod;
            PaymentStatus = paymentStatus;
            OrderStatus = "Placed";
        }

        public void PrintInvoice()
        {
            Console.WriteLine("\n========== INVOICE ==========");
            Console.WriteLine("Order Id      : " + OrderId);
            Console.WriteLine("Date          : " + Date);
            Console.WriteLine("Customer Name : " + CustomerName);
            Console.WriteLine("Address       : " + Address);
            Console.WriteLine("------------------------------");
            foreach (CartItem item in Items)
            {
                Console.WriteLine(item.ProductName + " x " + item.Quantity + " = Rs. " + item.GetSubtotal());
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Total         : Rs. " + Total);
            Console.WriteLine("Discount      : Rs. " + Discount);
            Console.WriteLine("GST           : Rs. " + GST);
            Console.WriteLine("Grand Total   : Rs. " + GrandTotal);
            Console.WriteLine("Payment Mode  : " + PaymentMethod);
            Console.WriteLine("Payment Status: " + PaymentStatus);
            Console.WriteLine("Order Status  : " + OrderStatus);
            Console.WriteLine("==============================");
        }
    }
}
