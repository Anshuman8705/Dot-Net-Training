using System;

public class NetBanking : PaymentGateway
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Payment using Net Banking : " + amount);
    }
}