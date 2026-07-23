using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ShopEaseApp
{
    // Module 5 - Order Module (Checkout / Place Order)
    // Module 7 - Order History (view previous orders, search, cancel, download invoice)
    public static class OrderManager
    {
        public static List<Order> Orders = new List<Order>();
        private static int nextOrderId = 5001;

        public static void Checkout()
        {
            if (AuthManager.LoggedInCustomer == null)
            {
                Console.WriteLine("Please login first.");
                return;
            }

            if (CartManager.Cart.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
                return;
            }

            Console.WriteLine("\n--- Checkout ---");

            string address = ConfirmAddress();
            string paymentMethod = PaymentManager.SelectPaymentMethod();
            string paymentStatus = PaymentManager.SimulatePayment(paymentMethod);

            PlaceOrder(address, paymentMethod, paymentStatus);
        }

        public static string ConfirmAddress()
        {
            Console.WriteLine("\nCurrent address: " + AuthManager.LoggedInCustomer.Address);
            Console.Write("Press 1 to use this address, or 2 to enter a new one: ");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                Console.Write("Enter new delivery address: ");
                string newAddress = Console.ReadLine();
                return newAddress;
            }

            return AuthManager.LoggedInCustomer.Address;
        }

        public static void PlaceOrder(string address, string paymentMethod, string paymentStatus)
        {
            double total = CartManager.GetCartTotal();
            double discount = total * CartManager.CouponDiscountPercent / 100;
            double afterDiscount = total - discount;
            double gst = afterDiscount * 0.18;
            double grandTotal = afterDiscount + gst;

            List<CartItem> orderedItems = new List<CartItem>(CartManager.Cart);

            Order newOrder = new Order(nextOrderId, AuthManager.LoggedInCustomer.Name, orderedItems,
                                        total, gst, discount, grandTotal, address, paymentMethod, paymentStatus);
            nextOrderId++;

            // Reduce stock quantity for each ordered product
            foreach (CartItem item in orderedItems)
            {
                Product product = ProductManager.Products.FirstOrDefault(p => p.ProductId == item.ProductId);
                if (product != null)
                    product.Quantity -= item.Quantity;
            }

            Orders.Add(newOrder);
            CartManager.ClearCart();

            Console.WriteLine("\nOrder placed successfully! Your Order Id is " + newOrder.OrderId);
            newOrder.PrintInvoice();
        }

        public static void ViewPreviousOrders()
        {
            if (AuthManager.LoggedInCustomer == null)
            {
                Console.WriteLine("Please login first.");
                return;
            }

            var myOrders = Orders.Where(o => o.CustomerName == AuthManager.LoggedInCustomer.Name).ToList();

            if (myOrders.Count == 0)
            {
                Console.WriteLine("You have no previous orders.");
                return;
            }

            Console.WriteLine("\n--- Your Orders ---");
            foreach (Order o in myOrders)
            {
                Console.WriteLine("Order Id: " + o.OrderId + " | Date: " + o.Date +
                                   " | Status: " + o.OrderStatus + " | Grand Total: Rs. " + o.GrandTotal);
            }
        }

        public static void SearchOrder()
        {
            Console.Write("\nEnter Order Id to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Order order = Orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                Console.WriteLine("Order not found.");
                return;
            }

            order.PrintInvoice();
        }

        public static void CancelOrder()
        {
            if (AuthManager.LoggedInCustomer == null)
            {
                Console.WriteLine("Please login first.");
                return;
            }

            Console.Write("\nEnter Order Id to cancel: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Order order = Orders.FirstOrDefault(o => o.OrderId == id &&
                                                 o.CustomerName == AuthManager.LoggedInCustomer.Name);
            if (order == null)
            {
                Console.WriteLine("Order not found.");
                return;
            }

            if (order.OrderStatus == "Cancelled")
            {
                Console.WriteLine("This order is already cancelled.");
                return;
            }

            order.OrderStatus = "Cancelled";
            Console.WriteLine("Order cancelled successfully.");
        }

        // Writes the invoice to a text file so it can be "downloaded"
        public static void DownloadInvoice()
        {
            Console.Write("\nEnter Order Id to download invoice: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Order order = Orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                Console.WriteLine("Order not found.");
                return;
            }

            string fileName = "Invoice_" + order.OrderId + ".txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("========== INVOICE ==========");
                writer.WriteLine("Order Id      : " + order.OrderId);
                writer.WriteLine("Date          : " + order.Date);
                writer.WriteLine("Customer Name : " + order.CustomerName);
                writer.WriteLine("Address       : " + order.Address);
                writer.WriteLine("------------------------------");
                foreach (CartItem item in order.Items)
                {
                    writer.WriteLine(item.ProductName + " x " + item.Quantity + " = Rs. " + item.GetSubtotal());
                }
                writer.WriteLine("------------------------------");
                writer.WriteLine("Total         : Rs. " + order.Total);
                writer.WriteLine("Discount      : Rs. " + order.Discount);
                writer.WriteLine("GST           : Rs. " + order.GST);
                writer.WriteLine("Grand Total   : Rs. " + order.GrandTotal);
                writer.WriteLine("Payment Mode  : " + order.PaymentMethod);
                writer.WriteLine("Payment Status: " + order.PaymentStatus);
                writer.WriteLine("Order Status  : " + order.OrderStatus);
                writer.WriteLine("==============================");
            }

            Console.WriteLine("Invoice downloaded as " + fileName);
        }
    }
}
