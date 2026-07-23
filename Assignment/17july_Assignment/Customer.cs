using System;

namespace ShopEaseApp
{
    // Module 1 - User Authentication
    // Simple class to hold customer details
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public Customer(int customerId, string name, string email, string password, string address)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
            Password = password;
            Address = address;
        }
    }
}
