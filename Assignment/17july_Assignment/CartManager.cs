using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopEaseApp
{
    // Module 4 - Shopping Cart (Customer)
    // Handles view products, add to cart, remove item, update quantity,
    // clear cart, view total, apply coupon
    public static class CartManager
    {
        public static List<CartItem> Cart = new List<CartItem>();
        public static double CouponDiscountPercent = 0;

        public static void ViewProducts()
        {
            ProductManager.ViewAllProducts();
        }

        public static void AddToCart()
        {
            ProductManager.ViewAllProducts();

            Console.Write("\nEnter Product Id to add to cart: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Product product = ProductManager.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (quantity > product.Quantity)
            {
                Console.WriteLine("Not enough stock available.");
                return;
            }

            CartItem existingItem = Cart.FirstOrDefault(c => c.ProductId == id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Cart.Add(new CartItem(product.ProductId, product.Name, product.Price, quantity));
            }

            Console.WriteLine(product.Name + " added to cart.");
        }

        public static void RemoveItem()
        {
            ViewCart();
            Console.Write("\nEnter Product Id to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());

            CartItem item = Cart.FirstOrDefault(c => c.ProductId == id);
            if (item == null)
            {
                Console.WriteLine("Item not found in cart.");
                return;
            }

            Cart.Remove(item);
            Console.WriteLine("Item removed from cart.");
        }

        public static void UpdateQuantity()
        {
            ViewCart();
            Console.Write("\nEnter Product Id to update quantity: ");
            int id = Convert.ToInt32(Console.ReadLine());

            CartItem item = Cart.FirstOrDefault(c => c.ProductId == id);
            if (item == null)
            {
                Console.WriteLine("Item not found in cart.");
                return;
            }

            Console.Write("Enter new quantity: ");
            item.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantity updated.");
        }

        public static void ClearCart()
        {
            Cart.Clear();
            CouponDiscountPercent = 0;
            Console.WriteLine("Cart cleared.");
        }

        public static void ViewCart()
        {
            Console.WriteLine("\n--- Shopping Cart ---");
            if (Cart.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
                return;
            }

            foreach (CartItem item in Cart)
            {
                Console.WriteLine(item.ProductName + " x " + item.Quantity + " = Rs. " + item.GetSubtotal());
            }
        }

        // Sample coupon code: SAVE10 gives 10% off
        public static void ApplyCoupon()
        {
            Console.Write("\nEnter coupon code: ");
            string code = Console.ReadLine();

            if (code.ToUpper() == "SAVE10")
            {
                CouponDiscountPercent = 10;
                Console.WriteLine("Coupon applied! You get 10% off.");
            }
            else
            {
                Console.WriteLine("Invalid coupon code.");
            }
        }

        public static double GetCartTotal()
        {
            return Cart.Sum(item => item.GetSubtotal());
        }

        public static void ViewTotal()
        {
            double total = GetCartTotal();
            double discount = total * CouponDiscountPercent / 100;
            double afterDiscount = total - discount;
            double gst = afterDiscount * 0.18;
            double grandTotal = afterDiscount + gst;

            Console.WriteLine("\n--- Cart Total ---");
            Console.WriteLine("Total          : Rs. " + total);
            Console.WriteLine("Discount       : Rs. " + discount);
            Console.WriteLine("GST (18%)      : Rs. " + gst);
            Console.WriteLine("Grand Total    : Rs. " + grandTotal);
        }
    }
}
