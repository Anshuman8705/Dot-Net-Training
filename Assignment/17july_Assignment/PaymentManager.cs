using System;

namespace ShopEaseApp
{
    // Module 6 - Payment Module
    // Lets the customer pick a payment method and simulates the result
    public static class PaymentManager
    {
        public static string SelectPaymentMethod()
        {
            Console.WriteLine("\n--- Select Payment Method ---");
            Console.WriteLine("1. Credit Card");
            Console.WriteLine("2. Debit Card");
            Console.WriteLine("3. UPI");
            Console.WriteLine("4. Cash On Delivery");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: return "Credit Card";
                case 2: return "Debit Card";
                case 3: return "UPI";
                case 4: return "Cash On Delivery";
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Cash On Delivery.");
                    return "Cash On Delivery";
            }
        }

        // Simulates a payment result. Cash On Delivery is always Pending.
        // Other methods succeed 80% of the time (just for demo purposes).
        public static string SimulatePayment(string method)
        {
            Console.WriteLine("\nProcessing payment via " + method + "...");

            if (method == "Cash On Delivery")
            {
                Console.WriteLine("Payment Status: Pending (to be paid on delivery)");
                return "Pending";
            }

            Random random = new Random();
            int outcome = random.Next(1, 11); // gives a number from 1 to 10

            if (outcome <= 8)
            {
                Console.WriteLine("Payment Status: Success");
                return "Success";
            }
            else
            {
                Console.WriteLine("Payment Status: Failed");
                return "Failed";
            }
        }
    }
}
