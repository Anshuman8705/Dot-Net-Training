using System;

public class UpiPayment : PaymentGateway
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Payment using UPI : " + amount);
    }
}