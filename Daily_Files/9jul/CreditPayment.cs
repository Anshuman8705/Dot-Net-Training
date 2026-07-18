using System;

public class CreditPayment : PaymentGateway
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Payment using Credit Card : " + amount);
    }
}